using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public GameObject fireballPrefab;
    public Vector3 direction;
    Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
        float r = transform.rotation.eulerAngles.z;
        switch (r)
        {
            case 0:
                movement = Vector3.right; break;
            case 90:
                movement = Vector3.right; break;
            case 180:
                movement = Vector3.right; break;
            case 260:
                movement = Vector3.right; break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * 4 * Time.deltaTime;
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;
        if (tag == "Player")
        {
            return;
        }
        Destroy(gameObject);
    }
}
