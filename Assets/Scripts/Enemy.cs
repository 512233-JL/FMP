using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 5f; 
    Animator animator; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hitbox")
        {
            //StartCoroutine(EnemyDeath()); 
            animator.SetBool("IsHit", true);
            health-= .5f; 

        }
    }




    //IEnumerator EnemyDeath()
    //{
    //    animator.SetBool("IsHit", true);
    //    yield return new WaitForSeconds(1f);
    //    gameObject.SetActive(false); 
    //}
}
