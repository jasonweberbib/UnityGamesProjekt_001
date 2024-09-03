using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard3dV2 : MonoBehaviour
{
    private Vector3 lastDirection;
    public GameObject Fireball3D;
    public GameObject Iceball3D;
    public static GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.forward;
        }


        if (Input.GetKey("s"))
        {
            movement += Vector3.back;
        }

        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }

        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        if ((movement.magnitude > 0))
        {
            lastDirection = movement;
        }

        transform.position += movement.normalized * Time.deltaTime * 4;

        if (Input.GetMouseButtonUp(0))
        {
            GameObject obj = Instantiate(Fireball3D, transform.position + lastDirection + Vector3.up, Quaternion.identity);
            obj.GetComponent<Fireball3D>().direction = lastDirection;
        }

        if (Input.GetMouseButtonUp(1))
        {
            GameObject objice = Instantiate(Iceball3D, transform.position + lastDirection + Vector3.up, Quaternion.identity);
            objice.GetComponent<Iceball3D>().direction = lastDirection;
        }

        if (movement.magnitude > 0)
        {
            lastDirection = movement.normalized;
            transform.position += movement.normalized * Time.deltaTime * 3;
            Rotate();
        }

    }
    public void Rotate()
    {
        float angle = Vector3.Angle(lastDirection, Vector3.forward);
        if (lastDirection.x < 0)
        {
            angle = angle * -1;
        }
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

}
