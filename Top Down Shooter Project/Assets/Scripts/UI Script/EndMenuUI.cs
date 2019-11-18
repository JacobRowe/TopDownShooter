using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuUI : MonoBehaviour
{
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
