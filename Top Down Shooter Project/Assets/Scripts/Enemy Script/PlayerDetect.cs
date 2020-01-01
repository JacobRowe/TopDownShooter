using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //go at player
        }
        else
        {
            //move around randomlike
        }
    }
}
