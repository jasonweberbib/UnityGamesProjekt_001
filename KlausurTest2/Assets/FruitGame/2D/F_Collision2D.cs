using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Collision2D : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Banana Eating");
        Destroy(gameObject);
    }
}
