using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3D : MonoBehaviour
{

    public GameObject jerma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard3dV2.player.transform.position;
        Vector3 distanceVector = playerPosition -transform.position + new Vector3(0,0.5f,0);
        distanceVector = distanceVector.normalized;
        transform.position = distanceVector * Time.deltaTime;
    }
}
