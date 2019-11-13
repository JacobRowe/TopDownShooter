using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    GameObject[] pauseObjects;

    private void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePauseMenu();
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
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
