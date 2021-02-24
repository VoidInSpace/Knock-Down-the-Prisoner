using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int GameLevel;
    public GameObject nextButton;

    public void PlayGame()
    {
        if(GameLevel == 1)
        {
            SceneManager.LoadScene("Level2");
        }
        if(GameLevel == 2)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    
    public void RetryLevel()
    {
        if (GameLevel == 1)
        {
            SceneManager.LoadScene("Gameplay");
        }
        if (GameLevel == 2)
        {
            SceneManager.LoadScene("Level2");
        }
        if (GameLevel == 3)
        {
            SceneManager.LoadScene("Level3");
        }
    }

    public void HomeScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
