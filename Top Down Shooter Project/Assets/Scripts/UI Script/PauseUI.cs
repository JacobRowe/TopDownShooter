using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseUI;

    void Start()
    {
        pauseUI.SetActive(false);
        Debug.Log("START");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == true)
            {
                ResumeGame();
            }
            else if (gamePaused == false)
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        Debug.Log("RESUME");
    }
    public void PauseGame()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
        Debug.Log("PAUSE");
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("Start Screen");
        Debug.Log("QUITMENU");
    }
    public void QuitToDesktop()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
