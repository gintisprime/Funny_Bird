using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float knockbackForce = 5f;         // Adjust the force as needed
    public float knockbackDuration = 0.2f;    // Adjust the duration as needed

    private Rigidbody2D rb;
    private float knockbackTimer;
    private bool facingRight = true;  // Assuming the player starts facing right

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if knockback is active
        if (knockbackTimer > 0)
        {
            // Calculate knockback direction based on the player's facing direction
            float forceDirection = facingRight ? knockbackForce : -knockbackForce;

            // Apply knockback force
            rb.velocity = new Vector2(forceDirection, knockbackForce);

            // Decrease the timer
            knockbackTimer -= Time.deltaTime;
        }
        else
        {
            // Reset velocity when knockback ends
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    public void KnockBack()
    {
        // Activate knockback
        knockbackTimer = knockbackDuration;

        // Update facing direction
        if (rb.velocity.x > 0)
        {
            facingRight = true;
        }
        else if (rb.velocity.x < 0)
        {
            facingRight = false;
        }
    }
}
