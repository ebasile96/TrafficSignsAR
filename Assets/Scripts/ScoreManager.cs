using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public ButtonClicked ButClick;
    public int score;

    public void ScorePlus()
    {
        score += 10;
    }

    public void ScoreMinus()
    {
        score -= 5;
    }
    private void Update()
    {
        ScoreCheck();
    }

    public void ScoreCheck()
    {
        if (score <= 0)
            score = 0;
    }
}
