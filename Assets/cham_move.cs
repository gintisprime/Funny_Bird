using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_move : MonoBehaviour
{
    
    public float speed = 0.5f;
    //bool crouch = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, Input.GetAxis("Vertical")*speed*Time.deltaTime, 0);



     // if (Input.GetButtonDown("Crouch")){
     //   crouch = true;
     // } else if (Input.GetButtonUp("Crouch")){
      //  crouch = false;
      //}

      


    }

    //public void OnCrouching (bool isCrouching){
    //    Animator.SetBool("IsCrouching", isCrouching);
    //}



}
