using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_move : MonoBehaviour
{
    public float speed = 5f;  // Adjust the speed value according to your needs
    public Animator animator;
    public new SpriteRenderer renderer;

    void Start() {



    }
    void Update()
    {


        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float running = horizontalInput * speed;

        animator.SetFloat("running", Mathf.Abs(running));  // Use Mathf.Abs to ensure positive values

        // Move the character
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow) && (horizontalInput == 0))
        {

            
               

        }
        

        // Change direction based on input
        if (horizontalInput < 0)
        {
            renderer.flipX = true;
            
        }
        else if (horizontalInput > 0)
        {
            // Moving left
            renderer.flipX = false;
        }


    }
}
