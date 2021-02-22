using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject playerBullet,enemyBullet;
   

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        playerBullet.SetActive(true);
        enemyBullet.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        playerBullet.SetActive(false);
        enemyBullet.SetActive(false);
    }
}
