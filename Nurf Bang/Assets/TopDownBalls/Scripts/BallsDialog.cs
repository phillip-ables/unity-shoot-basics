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
    private void Awake()
    {
        sentences = new string[] {
            "!HoW MaNy FiLtErS dO yOu HiDe BeHiNd My LoVe?",
            "!DOES HE KNOW YOU CALL ME DADDY?",
            "or that youve wore me on your face in ways he cant understand",
            "how do you smile knowing what youve done"
        };
    }

    
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
