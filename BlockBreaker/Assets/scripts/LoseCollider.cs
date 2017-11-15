using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager myLevelManager;

    //is called when Collision happens
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision with "+ collision.gameObject.name);
        
    }

    //is called when Collider is a Trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        myLevelManager.LoadLevel("Win");
    }

    // Use this for initialization
    void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
