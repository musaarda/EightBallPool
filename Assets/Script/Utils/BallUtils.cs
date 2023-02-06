using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Utils
{
    /// <summary>
    /// BallUtils: Functions related to Ball operations
    /// </summary>
    public class BallUtils
    {

        public static bool CheckIfHasBallScript(GameObject ball)
        {
            return ball.GetComponent<Ball>() != null ? true : false;
        }

        public static BallNumbersEnum? GetBallNumber(GameObject ball)
        {
            if (CheckIfHasBallScript(ball))
            {
                return ball.GetComponent<Ball>().ballNumber;
            }
            return null;
        }

        public static SphereCollider GetSphereColliderComponent(GameObject ball)
        {
            return ball.GetComponent<SphereCollider>();
        }

        public static Rigidbody GetRigidbodyComponent(GameObject ball)
        {
            return ball.GetComponent<Rigidbody>();
        }

        public static void StopTheBall(GameObject ball)
        {
            // Check the SphereCollider -> remove bounce material
            SphereCollider sc = GetSphereColliderComponent(ball);
            if (sc != null)
            {
                RemovePhysicsMaterial(sc);
            }

            // Check Rigidbody
            Rigidbody rb = GetRigidbodyComponent(ball);
            if (rb != null)
            {
                SetVelocity(rb, Vector3.zero);
                SetDrag(rb, 1f);
                SetUseGravity(rb, true);
                RemoveConstraints(rb);
            }
        }

        public static void RemovePhysicsMaterial(SphereCollider sc)
        {
            sc.material = null;
        }

        public static void SetVelocity(Rigidbody rb, Vector3 velocity)
        {
            rb.velocity = velocity;
        }

        public static void SetDrag(Rigidbody rb, float drag)
        {
            rb.drag = drag;
            rb.angularDrag = drag;
        }

        public static void SetUseGravity(Rigidbody rb, bool useGravity)
        {
            rb.useGravity = useGravity;
        }

        public static void RemoveConstraints(Rigidbody rb)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }

}
