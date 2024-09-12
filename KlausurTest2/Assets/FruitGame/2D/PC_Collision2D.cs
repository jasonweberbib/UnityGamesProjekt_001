using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Collision2D : MonoBehaviour
{
    public FruitSpawner spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touching Eating");
    }
}
