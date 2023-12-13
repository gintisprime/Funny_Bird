using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public Collider2D HitArea;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyPressed (KeyCode.Space))
        {
            Attacking();
            HitArea.enabled = true;
            
        }
        else
        {
            HitArea.enabled = false;
        }
        
    }

    private void Attacking()
    {

        animator.SetTrigger("Attack");
    }
}

