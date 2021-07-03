using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // The time in seconds
    public float time;
    public bool gameOver => time < 0;

    public int toPick;
    private int pickedUp = 0;

    // Canvas fields
    public Text bananaCollect;
    public Text timeText;
    public Text gameOverText;

    private void Start()
    {
        DisplayTime(time);
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
        gameOverText.enabled = false;
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
        gameOverText.enabled = true;
    }

    private void BananaPicked()
    {
        pickedUp++;
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
    }

    private void DisplayTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timeText.text = minutes.ToString() + ":" + seconds;
    }
}
