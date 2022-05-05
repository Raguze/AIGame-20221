using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class FSM : MonoBehaviour
    {
        public State CurrentState { get; protected set; }

        public float frequency = 0.1f;

        public Dictionary<AIState, State> stateList = new Dictionary<AIState, State>();

        private void Awake()
        {
            GameController.Instance.fsm = this;
        }

        public void StartFSM()
        {
            StartCoroutine(Loop());
        }

        public void AddState(State newState)
        {
            stateList.Add(newState.type,newState);
        }

        public void ChangeState(AIState type)
        {
            if(CurrentState != null)
            {
                CurrentState.Exit();
            }

            CurrentState = stateList[type];
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