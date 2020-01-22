using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am the Number Wizard.");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Now, tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius.");
        }
    }
}
