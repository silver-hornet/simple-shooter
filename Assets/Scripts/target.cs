using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    void OnEnable()
    {
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
}
