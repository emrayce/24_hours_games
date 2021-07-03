using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // The time in seconds
    public float time;
    public bool gameOver => time <= 0;

    public int toPick;
    private int pickedUp = 0;

    // Canvas fields
    public Text bananaCollect;
    public Text timeText;
    public Text gameOverText;
    public Button restart;

    private void Start()
    {
        Time.timeScale = 1f;
        DisplayTime(time);
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
        gameOverText.enabled = false;
        restart.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (gameOver)
        {
            GameOver();
        }
        else
        {
            DecreaseTime();
        }
    }

    private void DecreaseTime()
    {
        time -= Time.deltaTime;
        DisplayTime(time);
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gameOverText.enabled = true;
        restart.gameObject.SetActive(true);
        DisplayTime(0);
    }

    public void BananaPicked()
    {
        pickedUp++;
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
    }

    private void DisplayTime(float time)
    {
        int seconds = Mathf.FloorToInt(time);
        timeText.text = seconds.ToString();
    }
}
