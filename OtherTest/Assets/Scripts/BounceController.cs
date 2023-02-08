using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : BounceElement
{

    // Start is called before the first frame update
    public void OnBallGroundHit()
    {
        app.model.bounces++;
        Debug.Log("Bounce " + app.model.bounces + " of " + app.model.winCondition);
 
        if (app.model.bounces >= app.model.winCondition)
        {
            app.view.ball.enabled = false;
            app.view.ball.GetComponent<Rigidbody>().isKinematic = false;
            OnGameComplete();
        }
    }


    void OnGameComplete()
    {
        Debug.Log("Victory!!!");
    }

   
}
