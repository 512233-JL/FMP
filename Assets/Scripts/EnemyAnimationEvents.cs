using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationEvents : MonoBehaviour
{
    Animator anim;
    Enemy enemy; 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        enemy = GetComponent<Enemy>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyDead()
    {
        anim.SetBool("IsHit", false);
        if (enemy.health <= 0)
        {
            Debug.Log("Dead"); 
            anim.SetBool("IsDead", true);
        }
       
    }
}
