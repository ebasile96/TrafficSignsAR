using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Vuforia;

public class QuizManager : MonoBehaviour
{
    //variables
    public GameObject QuizTab;
    public List<string> SignsNames = new List<string>();
    public List<Text> buttons = new List<Text>();
    List<Text> answers = new List<Text>();
    public List<Button> buttonToClearList = new List<Button>();
    int index;
    [HideInInspector]
    public Recognizer target;

    
 
    //methods
    public void OnTargetFound()
    {
        QuizTab.SetActive(true);
        target = FindObjectOfType<Recognizer>();
        foreach (Text buttonText in buttons)
        {
            index = UnityEngine.Random.Range(0, SignsNames.Count);
            buttonText.text = SignsNames[index];
            if (buttonText.text == target.Name)
                buttonText.text = SignsNames[index + 1];
            answers.Add(buttonText);
        }
        RightChoiseFiller();
    }

    public void RightChoiseFiller()
    {
        index = UnityEngine.Random.Range(0, answers.Count);
        answers[index].text = target.Name;
    }

    public void OnTargetLost()
    {
        QuizTab.SetActive(false);
        ButtonClearer();
    }

    public void ButtonClearer()
    {
        foreach (Button _button in buttonToClearList)
        {
            _button.image.color = new Color(0.4012f, 0.4259f, 0.5094f, 1);
        }
        
 
    }

    
}
