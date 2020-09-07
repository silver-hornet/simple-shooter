using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab; 

    void Start()
    {
        InvokeRepeating("EnemySpawn", 2, 5);
    }

    void EnemySpawn()
    {
        Instantiate(enemyPrefab);
    }
}
