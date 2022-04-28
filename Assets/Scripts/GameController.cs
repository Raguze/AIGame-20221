using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI;

public class GameController : MonoBehaviour
{
    public FSM fsm;
    static public GameController Instance { get; protected set; }

    private void Awake()
    {
        Instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
