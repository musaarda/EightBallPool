using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using Utils;

/// <summary>
/// CueTip class is responsible for collision detection with the Cue Ball.
/// </summary>
public class CueTip : MonoBehaviour
{

    Transform parent;

    private void Awake()
    {
        // Cache parent
        parent = transform.parent;
    }

    private void OnTriggerEnter(Collider other)
    {
        // check if the colliding object is a ball
        if (MiscUtils.TagComparer(other.gameObject, TagsEnum.Ball))
        {
            // Catch the collision with the White ball
            if (BallUtils.GetBallNumber(other.gameObject) == BallNumbersEnum.White)
            {
                Debug.Log("Cue is Triggered");
                parent.gameObject.SetActive(false);
            }
        }
    }

}
