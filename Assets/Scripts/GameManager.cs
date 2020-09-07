using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject ammoPrefab;
    public float ammo = 6;

    void Start()
    {
        InvokeRepeating("EnemySpawn", 1, 2);
        InvokeRepeating("AmmoSpawn", 10, 10);
    }

    void EnemySpawn()
    {
        Instantiate(enemyPrefab);
    }

    void AmmoSpawn()
    {
        Instantiate(ammoPrefab);
    }
}
