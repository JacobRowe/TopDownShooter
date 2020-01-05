using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    //when the players collider interacts with the win items trigger routine runs
    void OnTriggerEnter2D(Collider2D ChangeScene) 
    {
        if (ChangeScene.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Game Win Screen");
        }
    }
}
