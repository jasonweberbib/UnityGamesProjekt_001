using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMovement3D : MonoBehaviour
{
    
    private float movementspeede = 5f;
    private Vector3 lastDirection;

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

        transform.position += movement.normalized * Time.deltaTime * movementspeede;

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
