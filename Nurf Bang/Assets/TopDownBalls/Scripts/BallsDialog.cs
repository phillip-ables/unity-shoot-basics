using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallsDialog : MonoBehaviour {
    //Variables
    public TextMeshProUGUI textDisplay;
    public float typingSpeed = 0.02f;

    private string[] sentences;
    private int index;

    //Methods
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }
}
