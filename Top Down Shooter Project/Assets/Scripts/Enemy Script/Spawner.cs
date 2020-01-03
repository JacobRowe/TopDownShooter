using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Collider2D Player;
    public float adjustmentAngle = 0;
    public float repeatTime, repeatRate;
    public int spawnCount, spawnLimit;


    private void OnTriggerExit2D(Collider2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            InvokeRepeating("Spawn", repeatTime, repeatRate);
        }
        else
        {
            Debug.Log("No Player");
        }
    }

    public void Spawn()
    {
    
        if (spawnCount == spawnLimit)
        {
            Debug.Log("Spawn reached");
        }
        else
        {
            Vector3 roatationInDegrees = transform.eulerAngles;
            roatationInDegrees.z += adjustmentAngle;

            Quaternion rotationInRadians = Quaternion.Euler(roatationInDegrees);

            Instantiate(prefabToSpawn, transform.position, rotationInRadians);

            spawnCount++;
        }


    }
}
