using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer = null;

    void Awake() //the first method that is run in Unity
    {
        //if myMusicPlayer is the 1st instance
        if (myMusicPlayer == null)
        {
            //myMusciPlayer = 1st SOund Object
            myMusicPlayer = this;

            print("Sound object " + this.gameObject.GetInstanceID().ToString());
            print("First Sound Object");

            //this.gameObject = the gameObject attached to this 
            //script, in our case SoundObject
            //DontDestroyOnLoad = do not destroy the gameObject
            //when changing scenes
            GameObject.DontDestroyOnLoad(this.gameObject);
        }

        //if myMusicPlayer != null
        //if SoundObeject already exists
        else
        {
            print("Sound object " + this.gameObject.GetInstanceID().ToString());

            //Destroy the 2nd gameObject created
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {

        



    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
