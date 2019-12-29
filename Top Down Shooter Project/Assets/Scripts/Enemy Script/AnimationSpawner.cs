using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        Vector3 roatationInDegrees = transform.eulerAngles;
        roatationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(roatationInDegrees);

        Instantiate(prefabToSpawn, transform.position, rotationInRadians);

        Debug.Log("Animation");
    }
}
