using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonPlayer : MonoBehaviour
{

    public static GameObject player;
    private float movementSpeed = 3.0f;
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.up;
            //print("w");
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.down;
        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed;

        if (movement.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (movement.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
