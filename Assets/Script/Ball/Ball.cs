using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class Ball : MonoBehaviour
{
    public BallNumbersEnum ballNumber;
}
