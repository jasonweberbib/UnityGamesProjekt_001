using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard3dV2 : MonoBehaviour
{
    private Vector3 lastDirection;
    public GameObject Fireball3D;
    public static GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement = Vector3.forward;
        }


        if (Input.GetKey("s"))
        {
            movement = Vector3.back;
        }

        if (Input.GetKey("a"))
        {
            movement = Vector3.left;
        }

        if (Input.GetKey("d"))
        {
            movement = Vector3.right;
        }

        if ((movement.magnitude > 0))
        {
            lastDirection = movement;
        }

        transform.position += movement.normalized * Time.deltaTime * 3;

        if (Input.GetMouseButtonUp(0))
        {
            GameObject obj = Instantiate(Fireball3D, transform.position + lastDirection, Quaternion.identity);
            obj.GetComponent<Fireball3D>().direction = lastDirection;
        }
    }

}
