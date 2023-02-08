using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : BounceElement
{
    void OnCollisionEnter()
    {
        app.controller.OnBallGroundHit();
    }
}
