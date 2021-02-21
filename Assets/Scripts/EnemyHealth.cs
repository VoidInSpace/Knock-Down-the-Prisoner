using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int numOfStars;

    public GameObject gameOver;

    public Image[] stars;
    public Sprite fullStar;
    public Sprite emptyStar;

    void Update()
    {
        if(health < 1)
        {
            gameOver.SetActive(true);
        }

        if(health > numOfStars)
        {
            health = numOfStars;
        }

        for (int i = 0; i < stars.Length; i++)
        {
            if(i < health)
            {
                stars[i].sprite = fullStar;
            }
            else
            {
                stars[i].sprite = emptyStar;
            }


            if(i < numOfStars)
            {
                stars[i].enabled = true;
            }
            else
            {
                stars[i].enabled = false;
            }
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
        }
    }
}
