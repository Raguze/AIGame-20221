using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AI
{

    public enum AIState
    {
        None,
        Idle,
        Walk,
    }

    public abstract class State
    {
        public virtual AIState type { get; }

        public State()
        {

        }

        public virtual void Enter()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Exit()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update()
        {
            throw new System.NotImplementedException();
        }
    }

}

