using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int Highscore;
    string highScoreKey = "HighScore";

    private void Start()
    {
        Highscore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

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

    private void OnDisable()
    {
        if (score > Highscore)
        {
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}
