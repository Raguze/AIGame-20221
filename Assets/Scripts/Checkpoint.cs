using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CheckpointType
{
    None, Start, End
}

public class Checkpoint : MonoBehaviour
{
    public CheckpointType type;
}
