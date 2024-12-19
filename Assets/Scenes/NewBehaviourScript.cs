using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// be sure to import TMPro because that's what we're using
using TMPro;

public class userInput : MonoBehaviour
{
    // this variable is storing the user input
    [SerializeField] private string inputText;
    // this function will ensure that our input is being held
    public void inputTextField(string input)
    {
        inputText = input;
    }

}
