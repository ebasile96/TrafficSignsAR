using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public ScoreManager scoreMgr;
    public TextMeshProUGUI ScoreTab;

    private void Update()
    {
        ScoreTab.text = "SCORE: " + scoreMgr.score;
    }

}
