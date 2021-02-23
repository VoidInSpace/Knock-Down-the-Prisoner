using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 10f;
    public GameObject gameOverUI;

    [SerializeField] TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime >= 0)
        {
            currentTime -= 1 * Time.deltaTime;
            int seconds = (int)(currentTime % 60);
            int minutes = (int)(currentTime / 60) % 60;

            string TimerString = string.Format("{0:00}:{1:00}", minutes,seconds);
            countdownText.text = "Time: \n" + TimerString;
        }
        else
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }
    }
}
