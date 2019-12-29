using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    public int spawnCount, spawnLimit;

    public void Spawn()
    {
        if (spawnCount == spawnLimit)
        {
            
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
