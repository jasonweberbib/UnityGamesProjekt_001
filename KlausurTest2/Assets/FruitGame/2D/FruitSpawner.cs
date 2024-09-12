using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] Fruit;
    public int frutsOnScreen = 0;
    public float timer = 3;
    public float timeCo = 1f;
    public static FruitSpawner spawner;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if ( timeCo == 1f)
        {
            if (timer <= 0)
            {
                spawning();
                timer = 3;
                timeCo = 2f;
            }
        }
        if ( timeCo == 2 )
        {
            if (timer <= 0)
            {
                spawning();
                timer = 3;
                timeCo = 1f;
            }
        }
        
        
    }

    private void spawning()
    {
        GameObject toSpawn = Fruit[Random.Range(0, 3)];
        Vector3 position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        Instantiate(toSpawn, position, Quaternion.identity);
    }
}
