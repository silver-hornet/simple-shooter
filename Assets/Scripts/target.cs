using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    float xRange = 4;
    float ySpawnPos = 1;
    float zRange = 4;

    void OnEnable()
    {
        transform.position = RandomSpawnPos();
        Die();
    }

    void Die()
    {
        Destroy(gameObject, 2);
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
