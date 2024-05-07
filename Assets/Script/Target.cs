using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject targetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        /*var position = new Vector3( Random.Range(0, 10),0,Random.Range(0, 10));
        Instantiate(targetPrefab, transform.position, Quaternion.identity);
        */
        string tag = collision2D.gameObject.tag;
        if (tag == "Player")
        {
           return;
        }
           float x = Random.Range(-9, 9);
           float y = Random.value * 10 - 5;
           Instantiate(targetPrefab, new Vector3(x, y, 0), Quaternion.identity);
        // erhöung von scoreinnerhalb der Hub skript
           hub.score += 1;
        // Targent wird zerstört
           Destroy(gameObject);

    }
}
