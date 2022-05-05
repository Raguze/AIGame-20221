using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentContainer : MonoBehaviour
{
    public Transform Transform { get; protected set; }
    public NavMeshAgent NavAgent { get; protected set; }

    private void Awake()
    {
        Transform = GetComponent<Transform>();
        NavAgent = GetComponent<NavMeshAgent>();
    }
}
