using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health;

        if (health <= 0)
        {
            Debug.Log("dead");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            health -= .1f;
        }
        if (collision.tag == "Healing" && health <=.7f)
        {
            health += .3f;
            Destroy(collision.gameObject);
        }
    }

}
