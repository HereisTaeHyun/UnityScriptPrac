using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSample : MonoBehaviour
{
    // enum Direction {None, North, East, South, West, Error}
    // // Start is called before the first frame update
    // void Start()
    // {
    //     Direction myDir;
    //     myDir = Direction.None;
    //     Debug.Log($"Now Direction : {myDir}");

    //     myDir = ReverseDirection(myDir);

    //     if(myDir != Direction.Error)
    //     {
    //         Debug.Log($"Now Direction : {myDir}");
    //     }
    // }

    // Direction ReverseDirection(Direction dir)
    // {
        // if(dir == Direction.North)
        // {
        //     dir = Direction.South;
        // }
        // else if(dir == Direction.South)
        // {
        //     dir = Direction.North;
        // }
        // else if(dir == Direction.East)
        // {
        //     dir = Direction.West;
        // }
        // else if(dir == Direction.West)
        // {
        //     dir = Direction.East;
        // }

    //     switch(dir)
    //     {
    //         case Direction.North:
    //             dir = Direction.South;
    //             break;
    //         case Direction.South:
    //             dir = Direction.North;
    //             break;
    //         case Direction.East:
    //             dir = Direction.West;
    //             break;
    //         case Direction.West:
    //             dir = Direction.East;
    //             break;
    //         default:
    //             Debug.LogError("알 수 없는 방향");
    //             dir = Direction.Error;
    //             break;
    //     }
    //     return dir;
    // }
}
