using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonClicked : MonoBehaviour
{
    public Button button;
    public QuizManager quizMgr;
    public ScoreManager scoreMgr;
   
    public void OnButtonClick()
    {
        string _text;
        _text = button.GetComponentInChildren<Text>().text;
        if (_text == quizMgr.target)
        {
            button.image.color = Color.green;
            scoreMgr.ScorePlus();
        }
        else
        {
            button.image.color = Color.red;
            scoreMgr.ScoreMinus();
        }
    }

}
