using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_phys : MonoBehaviour
{
    public float jumpSpeed = 5;
    public float arlimit = -10;
    public float dexlimit = 9;

    //Knockback factors
    public float knockbackForce;

    public Animator animator;
    Rigidbody2D rb;
    private bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.velocity += new Vector2(0, jumpSpeed);
            animator.SetBool("Jumping", true);
        }
        else
        {
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

    // Ground check 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }

        
       
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Vector2 difference = (transform.position - other.transform.position).normalized;
            Vector2 force = difference * knockbackForce;
            rb.AddForce(force, ForceMode2D.Force); //if you don't want to take into consideration enemy's mass then use ForceMode.VelocityChange
            // change to other layer for a bit 
            //change back again
        }
    }

}
