using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardConsole : MonoBehaviour
{
    //Class universal area so they can accessible to the functions blocks below
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        //max being an integer


        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down ? Lower, Push Enter = Correct");

    }

    // Update is called once per frame
    void Update()
    {
        //Works when if UpArrow key KeyCode has been pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed. ");
            //if the guess is to low 
            min = guess;
            //The it will add the following formula having a new value assigned
            //to guess. This is the logic to updating the guess
            guess = (max + min) / 2;
            Debug.Log(guess);

        }//Works when if DownArrow key KeyCode has been pressed
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed. ");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        } //Works when if Return/Enter key KeyCode has been pressed
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key has been pressed");
        }
    }
}
