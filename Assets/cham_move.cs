using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_move : MonoBehaviour
{
    
    public float speed = 0.5f;
    public Animator anim;
    Vector2 movement;


    void Start()  {
      anim = GetComponent<Animator>();
    }


    void Update()
    {
      transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, Input.GetAxis("Vertical")*speed*Time.deltaTime, 0);

      if (Input.GetButtonDown("Fire1")) anim.Play("jump");
    }






}
