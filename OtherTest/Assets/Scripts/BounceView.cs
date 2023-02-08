using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceView : BounceElement
{
    Rigidbody rb;

    //anything we want to keep track of in our scene, put here
    public BallView ball;

    public void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.freezeRotation= true;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.forward * 50);
            Debug.Log("Working1");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.forward * 50);
            Debug.Log("Working2");
        }

    }


}
