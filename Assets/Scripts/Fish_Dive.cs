using UnityEngine;

public class Fish_Dive : MonoBehaviour
{
    public float Speed = 5.0f;
    public float Axl = 2.0f;
    public float maxHeight = 5.0f;
    

    private SpriteRenderer spriteRenderer;
    private bool isMovingUp = true;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        
    }



    private void FixedUpdate()
    {
        MoveFish();

    }

    void MoveFish()
    {
        Speed -= Axl * Time.deltaTime;
        float verticalMovement = isMovingUp ? Speed - Axl*Time.fixedDeltaTime : -Speed * Axl;

        transform.Translate(new Vector3(0, verticalMovement, 0) * Time.deltaTime);

        // Check if the fish should switch its sprite renderer's X-axis
        if (isMovingUp && transform.position.y >= maxHeight)
        {
            isMovingUp = false;
            spriteRenderer.flipY = true;
        }
        else if (!isMovingUp && transform.position.y <= 0)
        {
            isMovingUp = true;
            spriteRenderer.flipY = false;
        }
    }
}
