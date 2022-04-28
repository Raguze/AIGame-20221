using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class WalkState : State
    {
        public override AIState type => AIState.Walk;

        public float Speed;

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