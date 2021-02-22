using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject playerBullet, enemyBullet;

    // Update is called once per frame
    void Update()
    {
        if (GameOverUI.activeInHierarchy)
        {
            Time.timeScale = 0f;
            playerBullet.SetActive(false);
            enemyBullet.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            playerBullet.SetActive(true);
            enemyBullet.SetActive(true);
        }
    }
}
