using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI;

public class GameController : MonoBehaviour
{
    public FSM fsm;
    static public GameController Instance { get; protected set; }

    public List<Checkpoint> checkpoints = new List<Checkpoint>();

    public PlayerController player;

    private void Awake()
    {
        Instance = this;

        player = FindObjectOfType<PlayerController>();

        checkpoints.AddRange(FindObjectsOfType<Checkpoint>());

        Checkpoint start = checkpoints.Find((c) => 
        {
            return c.type == CheckpointType.Start;
        });


        float playerY = player.transform.position.y;
        player.transform.position = new Vector3(
            start.transform.position.x,
            playerY,
            start.transform.position.z
        );
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
