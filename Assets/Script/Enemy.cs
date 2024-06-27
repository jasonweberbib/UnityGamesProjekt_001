using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard.player.transform.position;
        Vector3 distanceVectore = playerPosition - transform.position;
        distanceVectore = distanceVectore.normalized;

        transform.position += distanceVectore * Time.deltaTime * 2;
    }

    private void OnCollision2DEnter(Collision2D coll)
    {
        if(tag == "Player")
        {
            
            Destroy(coll.gameObject);
            Destroy(gameObject);
            return;
        }
        if(tag == "Fireball")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            return;
        }

        float x = Random.Range(-9, 9);
        float y = Random.value * 10 - 5;
        Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}
