using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Movement : MonoBehaviour
{

    Vector3 movement = Vector3.zero;
    Vector3 lastMovement = Vector3.zero;
    float movementSpeed = 6f;
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveing();
    }

    private void moveing()
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
