using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpawner : MonoBehaviour
{
    public GameObject prefabOnDieToSpawn;
    public GameObject prefabOnHurtToSpawn;
    public float adjustmentAngle = 0;

    public void SpawnDie()
    {
        Vector3 roatationInDegrees = transform.eulerAngles;
        roatationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(roatationInDegrees);

        Instantiate(prefabOnDieToSpawn, transform.position, rotationInRadians);

        Debug.Log("Animation");
    }

    public void SpawnHurt()
    {
        Vector3 roatationInDegrees = transform.eulerAngles;
        roatationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(roatationInDegrees);

        Instantiate(prefabOnHurtToSpawn, transform.position, rotationInRadians);

        Debug.Log("Animation");
    }
}
