using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starter : MonoBehaviour
{
    int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            SceneManager.LoadSceneAsync(currentScene +1);
        }
    }
}
