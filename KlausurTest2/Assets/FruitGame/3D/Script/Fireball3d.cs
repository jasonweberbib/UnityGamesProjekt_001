using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball3d : MonoBehaviour
{

    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * 4 * Time.deltaTime;
    }
}
