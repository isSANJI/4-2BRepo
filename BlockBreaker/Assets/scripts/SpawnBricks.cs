using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBricks : MonoBehaviour {

    public List<GameObject> listOfBricks = new List<GameObject>();

	// Use this for initialization
	void Start () {

        if (SceneManager.GetActiveScene().name == "Level02")
        {
            //loads all GameObjects in Resources folder
            //and saves them in List
            listOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

            Vector3 position = new Vector3(-5f, 3f, 0);

            for(int i = 1; i <= 10; i++)
            {
                //gets a random object from list and saves it in go
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                //creates an instance of go at the position
                Instantiate(go, position, Quaternion.identity);

                position.x += 1f;

            }

            position = new Vector3(-5f, 2.5f, 0);

            for (int i = 1; i <= 10; i++)
            {
                //gets a random object from list and saves it in go
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                Instantiate(go, position, Quaternion.identity);

                position.x += 1f;

            }

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
