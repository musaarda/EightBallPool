using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enums namespace includes public enums for static state data. 
/// These enums make easy to refactor and extend code in the future.
/// </summary>
namespace Enums
{
    public enum TagsEnum
    {
        Untagged,
        Respawn,
        Finish,
        EditorOnly,
        MainCamera,
        Player,
        GameController,
        Ball,
        Cue
    }

    public enum BallNumbersEnum
    {
        White = 0,
        Ball_1 = 1,
        Ball_2 = 2,
        Ball_3 = 3,
        Ball_4 = 4,
        Ball_5 = 5,
        Ball_6 = 6,
        Ball_7 = 7,
        Ball_8 = 8,
        Ball_9 = 9,
        Ball_10 = 10,
        Ball_11 = 11,
        Ball_12 = 12,
        Ball_13 = 13,
        Ball_14 = 14,
        Ball_15 = 15,
    }
}
