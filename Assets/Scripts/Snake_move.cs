using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake_move : MonoBehaviour
{
    public Rigidbody2D rb;
    public int Lifetotal = 3;
    public int snakespeed = 20;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * snakespeed;
    }
}
