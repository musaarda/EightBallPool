using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;
using Utils;

public class Pocket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if the colliding object is a ball
        if (MiscUtils.TagComparer(other.gameObject, TagsEnum.Ball))
        {
            Debug.Log("Ball in the pocket: " + BallUtils.GetBallNumber(other.gameObject).ToString());
            BallUtils.StopTheBall(other.gameObject);
        }
    }
}
