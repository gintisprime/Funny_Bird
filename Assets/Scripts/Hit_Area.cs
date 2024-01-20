using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Area : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D HitArea;

    public float hit_timer;
    void Start()
    {
        HitArea = GetComponent<Collider2D>();
        HitArea.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            StartCoroutine(enable_hit_area());
        }
    }

    IEnumerator enable_hit_area()
    {
        HitArea.enabled = true;
        yield return new WaitForSeconds(hit_timer);
        HitArea.enabled = false;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
            Destroy(collision.gameObject);
    }
}
