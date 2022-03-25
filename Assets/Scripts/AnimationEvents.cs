using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    private Animator anim;
    PlayerMovement playerMovement;
    public GameObject hitbox;
    public GameObject kickHitbox;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    public void onAnimationEnd()
    {
        anim.SetBool("IsKicking", false);
        anim.SetBool("IsPunching", false);
        playerMovement.isAttacking = false;
        hitbox.SetActive(false);
        kickHitbox.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
