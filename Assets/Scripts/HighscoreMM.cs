using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighscoreMM : MonoBehaviour
{
    int highscore;
    string highscorekey = "HighScore";
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt(highscorekey, 0);
        text = GetComponent<TextMeshProUGUI>();
        text.text = highscore.ToString();
    }

    
}
