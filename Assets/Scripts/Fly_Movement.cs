using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_Movement : MonoBehaviour
{


    public float FlySpeed = 5f;        // Adjust the charging speed as needed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * FlySpeed * Time.deltaTime);
    }
}
