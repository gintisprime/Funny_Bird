using UnityEngine;

public class Bird_movement : MonoBehaviour
{
    public float chargeSpeed = 5f;        // Adjust the charging speed as needed
    public float fluctuationAmount = 1f;  // Adjust the fluctuation amount as needed
    public float fluctuationSpeed = 2f;   // Adjust the fluctuation speed as needed

    private Vector3 position;
    private Vector3 axis;

    void Start()
    {
        position = transform.position;
        axis = transform.up;
    }

    void Update()
    {
        Bird_Move();
    }

    void Bird_Move() {

        // Charge towards the left
        position += Vector3.left * Time.deltaTime * chargeSpeed;

        // Fluctuate in a wave pattern vertically

        transform.position = position + axis * Mathf.Sin(Time.time * fluctuationSpeed) * fluctuationAmount;
    }
}
