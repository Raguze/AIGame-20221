using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class IdleState : State
    {
        public override AIState type { get => AIState.Idle; }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }
    }

}