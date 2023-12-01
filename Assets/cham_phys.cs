using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_phys : MonoBehaviour
{
    public float jumpSpeed = 5;
    public float arlimit = -10;
    public float dexlimit = 9;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
 rb.velocity += new Vector2(0, jumpSpeed);
    }

            if(transform.position.x < arlimit) {
 Vector3 v = transform.position;
 v.x = arlimit;
 transform.position = v;
 }
    

            if(transform.position.x > dexlimit) {
 Vector3 v = transform.position;
 v.x = dexlimit;
 transform.position = v;
 }
    }
}
