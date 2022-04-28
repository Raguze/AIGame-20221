using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class FSM : MonoBehaviour
    {
        public State CurrentState { get; protected set; }

        public float frequency = 0.1f;

        private void Awake()
        {
            GameController.Instance.fsm = this;
        }

        private void Start()
        {
            StartCoroutine(Loop());
        }

        public void ChangeState(State newState)
        {
            if(CurrentState != null)
            {
                CurrentState.Exit();
            }

            CurrentState = newState;
            CurrentState.Enter();
        }

        IEnumerator Loop()
        {
            while(true)
            {
                if (CurrentState != null)
                {
                    CurrentState.Update();
                }
                yield return new WaitForSeconds(frequency);
            }
        }

        IEnumerator LoopBase()
        {
            Debug.Log("Start Loop");
            yield return new WaitForSeconds(2);

            Debug.Log("Step 1");
            yield return new WaitForSeconds(2);

            Debug.Log("Step 2");
            yield return new WaitForSeconds(2);

            Debug.Log("Step 3");
            yield return new WaitForSeconds(2);

            Debug.Log("End Loop");
        }
    }

}