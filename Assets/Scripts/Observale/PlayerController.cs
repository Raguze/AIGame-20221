using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observable
{
    public class PlayerController : MonoBehaviour
    {
        public GenericObservable<int> Hp = new GenericObservable<int>(10);
        public GenericObservable<float> Speed = new GenericObservable<float>(1);

        private void Awake()
        {
            Hp.OnChange += (int hp) =>
            {
                Debug.Log($"Lambda {hp}");
            };
            Hp.OnChange += (int hp) =>
            {
                if (hp <= 0)
                {
                    Destroy(gameObject);
                }
            };

            Speed.OnChange += (float speed) =>
            {
                if(speed > 20)
                {
                    Debug.Log($"Speed {speed}");
                }
            };
        }

        private void ChangeHp(int hp)
        {
            Debug.Log($"ChangeHp {hp}");
        }

        private void ChangeHp2(int hp)
        {
            Debug.Log($"ChangeHp2 {hp}");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Hp.Value -= 1;
            }

            Speed.Value += Time.deltaTime;
        }
    }
}
