using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    public float ammo = 2;

    void Start()
    {
        InvokeRepeating("EnemySpawn", 1, 2);
    }

    void EnemySpawn()
    {
        Instantiate(enemyPrefab);
    }
}
