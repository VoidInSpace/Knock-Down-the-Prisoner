using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    public GameObject playerBullet, enemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        playerBullet.SetActive(true);
        enemyBullet.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
