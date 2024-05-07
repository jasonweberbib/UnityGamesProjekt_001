using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Wizard : MonoBehaviour
{
    float movementSpeed = 4.0f;
    public GameObject fireballPrefab;
    private float fireRate = 0.7f;
    private float canFire = -1f;
    Vector3 movement = Vector3.zero;
    float fbRotate = 0;
    public Vector3 direction;
    Vector3 lastMovement = Vector3.zero;
    private Animator animator;

    // Cavnvas Statts
    public static int health;
    public static int mana;

    public TMP_Text healthText;
    public TMP_Text manaText;


    
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Walking", false);

        Vector3 movement = Vector3.zero;
        if (Input.GetKey("d")) 
        {
            //movement += new Vector3(0.01f, 0,0);
            movement += Vector3.right;
            fbRotate = 0;
            animator.SetBool("Walking", true);
        } 
        if (Input.GetKey("a")) 
        {
            //movement += new Vector3(-0.01f, 0, 0);
            movement += Vector3.left;
            fbRotate = 180;
            animator.SetBool("Walking", true);
        }
        if (Input.GetKey("w"))
        {
            //movement += new Vector3(0, 0.01f, 0);
            movement += Vector3.up;
            fbRotate = 90;
            animator.SetBool("Walking", true);
        }
        if (Input.GetKey("s"))
        {
            //movement += new Vector3(0, -0.01f, 0);
            movement += Vector3.down;
            fbRotate = 270;
            animator.SetBool("Walking", true);
        }

        if(movement.x > 0 || movement.y > 0  || movement.x < 0 || movement.x < 0)
        {
            lastMovement = movement;
        }

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > canFire)
        {
            canFire = Time.time + fireRate;
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.transform.Rotate(0, 0, fbRotate);
            obj.GetComponent<Fireball>().direction = lastMovement;
        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed;
    }
}
