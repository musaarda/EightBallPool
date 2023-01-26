using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BallHit is responsible for moving the Cue Ball (0) by Rigidbody.AddForce()
/// </summary>
public class BallHit : MonoBehaviour
{

    [SerializeField] private float impulse;
    private Rigidbody rb;

    private void Awake()
    {
        // Caching
        rb = GetComponent<Rigidbody>();
    }

    // Collision Trigger
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball is Hit by the Cue");
        AddForceToRigidbody();
    }


    private void AddForceToRigidbody()
    {
        // direction vector
        Vector3 direction = new Vector3(1f, -0.1f, 0f);
        rb.AddForce(direction * impulse, ForceMode.Impulse);
    }
}
