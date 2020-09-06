using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    void Start()
    {
        Instantiate(enemyPrefab);
    }

    void Update()
    {

    }
}
