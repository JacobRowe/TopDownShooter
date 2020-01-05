using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuUI : MonoBehaviour
{
    public void NextLevel()
    {
        //would go to next level if it existed, with carrying score over
    }

    public void RestartGame()
    {
        Debug.Log("RESTART");
        SceneManager.LoadScene("Level 1");
    }
    public void QuitToDesktop()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
