using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallsDialog : MonoBehaviour {
    //Variables
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI continueButton;
    public float typingSpeed = 0.02f;
    public float buttonSpeed = 0.01f;
    public int buttonGrowth = 2;
    public Animator textDisplayAnimation;

    private int textSize = 0;
    private int buttonSize = 400;
    private string[] sentences;
    private int index;
    //Methods
    private void Start()
    {
        continueButton.fontSize = 0;
        sentences = new string[] {
            "!HoW MaNy FiLtErS dO yOu HiDe BeHiNd My LoVe?",
            "!HoW MaNy FiLtErS dO yOu HiDe BeHiNd My LoVe?",
            "!DOES HE KNOW YOU CALL ME DADDY?",
            "or that youve wore me on your face in ways he cant understand",
            "how do you smile knowing what youve done"
        };
        StartCoroutine(Type());
    }

    
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        StartCoroutine(Continue());
    }

    IEnumerator Continue()
    {
        for(int i = 0; i < buttonSize / buttonGrowth; i++)
        {
            textSize += buttonGrowth;
            continueButton.fontSize = textSize;
            yield return new WaitForSeconds(buttonSpeed);
        }
        NextSentence();
    }

    public void NextSentence()
    {
        textDisplayAnimation.SetTrigger("Change");
        textSize = 0;
        textDisplay.text = "";
        continueButton.fontSize = textSize;

        if (index < sentences.Length - 1)
        {
            index++;
            StartCoroutine(Type());
        }
    }
}
