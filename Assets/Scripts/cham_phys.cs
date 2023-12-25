using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_phys : MonoBehaviour
{
    public float jumpSpeed = 5;
    public float arlimit = -10;
    public float dexlimit = 9;

    public Animator animator;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += new Vector2(0, jumpSpeed);
            animator.SetBool("Jumping", true);
        }
        else {

            animator.SetBool("Jumping", false);
        
        }


        if (Input.GetButton("Fire2"))
        {
            
            animator.SetBool("Ducking", true);
        }
        else
        {

            animator.SetBool("Ducking", false);

        }
        if (transform.position.x < arlimit)
        {
            Vector3 v = transform.position;
            v.x = arlimit;
            transform.position = v;
        }

        if (transform.position.x > dexlimit)
        {
            Vector3 v = transform.position;
            v.x = dexlimit;
            transform.position = v;
        }

        // Move the spacebar check outside of the x-position limit block
        if (Input.GetButtonDown("Fire1"))
        {
            Attacking();
        }
    }

    private void Attacking()
    {
        animator.SetTrigger("Attack");
    }

    private void OnLanding() {

        animator.SetBool("Jumping", false);
    }
}
