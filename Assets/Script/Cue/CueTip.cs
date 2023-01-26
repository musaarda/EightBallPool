using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Catch the collision with the ball
        Debug.Log("Cue is Triggered");
        parent.gameObject.SetActive(false);
    }

}
