using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour
{

    public int AttackForce = 3;
    public GameObject hit_area;


    private void Start()
    {
        hit_area = gameObject;  
    }

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
        {
        
            hit_area.SetActive(true);

        }
        else
        {
            hit_area.SetActive(false);
        }

    }
    private void OnTriggerEnter2D(Collider2D bandit)
    {
        EnemyHealth enemy_health = bandit.GetComponent<EnemyHealth>();


        if (enemy_health != null)

        { 
            enemy_health.TakeDamage(AttackForce);
        }

    }
}
