using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
        }
        
        //if ball is going down
        //increase y in the negative
        if (collision.gameObject.name == "Top Roof")
        {
            randomY = Random.Range(-0.5f, 0f);
            Vector2 tweak = new Vector2(randomX, randomY);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
        else
        {

            Vector2 tweak = new Vector2(randomX, randomY);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }

    }

    // Use this for initialization
    void Start () {

        randomX = Random.Range(0f, 0.5f);
        randomY = Random.Range(0f, 0.5f);

        //attaches the object itslef rather than
        //having to attach the Paddle myself
        //from Unity
        myPaddle = GameObject.FindObjectOfType<Paddle>();

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
