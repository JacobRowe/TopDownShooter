using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    //pause UI 
    GameObject[] pauseObjects;

    private void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        //hidePaused();
    }
    private void Update()
    {
        //pauses game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPausemenu();
            }
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePauseMenu();
        }
    }

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
    }
    private void OnDisable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }

    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "SCORE: " + playerScore.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerScore = 0;
    }
    public void controlPauseMenu()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPausemenu();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePauseMenu();
        }
    }

    public void showPausemenu()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePauseMenu()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
}
