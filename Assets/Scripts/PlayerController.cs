using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI;

public class PlayerController : MonoBehaviour
{
    public FSM Fsm { get; protected set; }
    public AgentContainer Container { get; protected set; }

    private void Awake()
    {
        Container = GetComponent<AgentContainer>();
        Fsm = GetComponent<FSM>();


        Fsm.AddState(new IdleState(Container));
        Fsm.AddState(new WalkState(Container));
    }

    private void Start()
    {
        Fsm.StartFSM();
    }
}
