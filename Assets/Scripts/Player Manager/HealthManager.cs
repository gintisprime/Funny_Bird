using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public static int health = 3;

    public Image[] hearts;

    public Sprite full_heart;

    public Sprite empty_heart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        health = 3;
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Image img in hearts) {

            img.sprite = empty_heart;

        }
        for (int i = 0; i < health; i++) {

            hearts[i].sprite = full_heart;
        
        }
    }
}
