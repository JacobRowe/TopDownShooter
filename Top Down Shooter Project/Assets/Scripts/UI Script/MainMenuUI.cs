using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("START");
        SceneManager.LoadScene("Level 1");
    }

    public void QuitToDesktop()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
