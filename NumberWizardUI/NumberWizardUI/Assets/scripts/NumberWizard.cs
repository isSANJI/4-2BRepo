using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    //creates 3 number variables
    int min = 1;
    int max = 1001;
    int guess = 500;
    int maxNumberOfTries = 10;

    public Text guessText;

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);

        guessText.text = guess.ToString();

        maxNumberOfTries--;
        if(maxNumberOfTries == 0) //if AI does not guess the number I win
        {
            SceneManager.LoadScene("Win");
            min = 1;
            max = 1001;
            guess = Random.Range(min, max); 
        }
    }
    
    // Use this for initialization
    void Start () {

        guess = Random.Range(min, max);
        guessText.text = guess.ToString();


    }
	
	
}
