using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reload : MonoBehaviour
{
    float xRange = 4;
    float ySpawnPos = 1;
    float zRange = 4;
    GameManager gameManager;

    void OnEnable()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        transform.position = RandomSpawnPos();
        Die();
    }

    void Die()
    {
        Destroy(gameObject, 2);
    }

    void OnMouseDown()
    {
        gameManager.ammo = 6;
        Destroy(gameObject);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}