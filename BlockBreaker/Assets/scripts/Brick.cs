using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public AudioClip crack;

    public int maxHits;

    private int numberOfHits;

    private LevelManager myLevelManager;

    private bool isBreakable = false;

    public static int breakableCount = 0;

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();
    }

    void HandleHits()
    {
        numberOfHits++;
        if (numberOfHits >= maxHits)
        {
            //decrement the number of breakable bricks
            breakableCount--;
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            Destroy(this.gameObject);

            myLevelManager.BrickDestroyed();

            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //isBreakable = (this.tag == "Break");

        if (isBreakable) //if isBreakable == true
        {
            
            HandleHits();
        }
        

        
    }

    // Use this for initialization
    void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        numberOfHits = 0;

        isBreakable = (this.tag == "Break");
        
        //keep track of breakable tags
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
