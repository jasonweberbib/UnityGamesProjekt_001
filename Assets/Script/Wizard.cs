using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Wizard : MonoBehaviour
{
    //Player Movment speed
    float movementSpeed = 4.0f;

    //Refrenc to fireballPrefab
    public GameObject fireballPrefab;
    // Valuse for Fireball Stamina / Firerate
    private float fireRate = 0.7f;
    private float canFire = -1f;

    //
    Vector3 movement = Vector3.zero;

    // Set Value for Fireball Rotation in fireballPrefab
    float fbRotate = 0;

    // Set Value for Wizard Rotation in Wizard
    //bool PlayerRotate = true;

    public Vector3 direction;
    Vector3 lastMovement = Vector3.zero;

    //Vector3 for Rotatior change
    //Vector3 PRotate = Vector3.Rotate;

    // Animation refrenc
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
        // Set Waking animation as False with no key pressed
        animator.SetBool("Walking", false);
        animator.SetBool("Attack", false);


        Vector3 movement = Vector3.zero;
        if (Input.GetKey("d")) 
        {
            //movement += new Vector3(0.01f, 0,0);
            movement += Vector3.right;
/*
            if (PlayerRotate == false){
                Vector3 rotation = new Vector3(0, 180, 0 * Time.deltaTime);
                transform.Rotate (rotation);
                PlayerRotate = true;
            }
*/
            fbRotate = 0;
            animator.SetBool("Walking", true);
        } 
        if (Input.GetKey("a")) 
        {
            //movement += new Vector3(-0.01f, 0, 0);
            movement += Vector3.left;
            //PRotate = Vector3.Rotate(0,180,0);
/*
            if (PlayerRotate == true){
                Vector3 rotation = new Vector3(0, 180, 0 * Time.deltaTime);
                transform.Rotate (rotation);
                PlayerRotate = false;
            }
*/
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
            animator.SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Attack", false);
        }   

        transform.position += movement.normalized * Time.deltaTime * movementSpeed;

        // Flip Character
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
