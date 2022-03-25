using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] float size;
    public bool isAttacking;

    public GameObject hitbox;
    public GameObject kickHitbox;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when moving right left
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(size,size,size);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-size, size, size);

        anim.SetBool("Walk", horizontalInput != 0);

        if (Input.GetKey(KeyCode.Mouse0)&&isAttacking == false)
        {
            // StartCoroutine(AnimationEnd());
            isAttacking = true;
            anim.SetBool("IsPunching", true);
            hitbox.SetActive(true); 
        }
        if (Input.GetKey(KeyCode.Mouse1) && isAttacking == false)
        {
            // StartCoroutine(AnimationEnd());
            isAttacking = true;
            anim.SetBool("IsKicking", true);
            kickHitbox.SetActive(true);
        }

    }
    //IEnumerator AnimationEnd()
    //{
    //    anim.SetBool("IsPunching", true);
    //    yield return new WaitForSeconds(0.1f);
    //    anim.SetBool("IsPunching", false);
    //}
    

}
