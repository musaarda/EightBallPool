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

    }

}
