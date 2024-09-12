using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{

    public GameObject Coin;
    public float timer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            spaningcoin();
            timer = 5;
        }
    }

    private void spaningcoin()
    {
        Vector3 position = new Vector3(Random.Range(-5f, 5f), 1, 0);
        Instantiate(Coin, position, Quaternion.identity);
    }
}
