using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    private int numberOfHits;

    private LevelManager myLevelManager;

    bool isBreakable = false;

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();
    }

    void HandleHits()
    {
        numberOfHits++;
        if (numberOfHits >= maxHits)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isBreakable = (this.tag == "Break");

        if (isBreakable) //if isBreakable == true
        {
            HandleHits();
        }
        

        
    }

    // Use this for initialization
    void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        numberOfHits = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
