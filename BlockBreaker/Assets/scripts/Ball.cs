using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

	// Use this for initialization
	void Start () {

        //save the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted) //if hasStarted == false
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0)) //left click
            {
                hasStarted = true;

                //applies a velocity of 2x and 10 y to the ball
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }

        
		
	}
}
