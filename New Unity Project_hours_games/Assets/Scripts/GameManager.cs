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

    private int key = 0;

    // Canvas fields
    public Text bananaCollect;
    public Text keyCollect;
    public Text timeText;
    public GameObject gameOverPanel;
    public GameObject victoryPanel;
    public GameObject pausePanel;

    private void Start()
    {
        Time.timeScale = 1f;
        DisplayTime(time);
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
        keyCollect.text = key.ToString();

        gameOverPanel.gameObject.SetActive(false);
        victoryPanel.SetActive(false);
        pausePanel.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
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
        gameOverPanel.gameObject.SetActive(true);
        DisplayTime(0);
    }

    public void Victory()
    {
        Time.timeScale = 0f;
        victoryPanel.SetActive(true);
    }

    public void BananaPicked()
    {
        pickedUp++;
        bananaCollect.text = pickedUp.ToString() + " / " + toPick.ToString();
    }

    public void KeyPicked()
    {
        key++;
        keyCollect.text = key.ToString();
    }

    public void UseKey()
    {
        key--;
        keyCollect.text = key.ToString();
    }

    public bool GotKey()
    {
        return key > 0;
    }

    private void DisplayTime(float time)
    {
        int seconds = Mathf.FloorToInt(time);
        timeText.text = seconds.ToString();
    }

    public bool IsEverythingCollected()
    {
        return pickedUp == toPick;
    }
}
