using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int numOfStars;
    public GameObject gameOver;
    public GameObject nextButton;


    public Image[] stars;
    public Sprite fullStar;
    public Sprite emptyStar;

    [SerializeField] TextMeshProUGUI gameOverText;


    void Update()
    {
        if(health < 1)
        {
            gameOver.SetActive(true);
            nextButton.SetActive(false);
            gameOverText.text = "You Lose!";
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
        if (col.gameObject.tag == "EnemyBullet")
        {
            health -= 1;
        }
    }
}
