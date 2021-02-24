using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject playerBullet , enemyBullet;


    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1f;
        playerBullet.SetActive(true);
        enemyBullet.SetActive(true);
    }
}
