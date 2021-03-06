using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class PrologueMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] float size;
    private GameObject door;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        door = GameObject.Find("Door");
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when moving right left
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(size, size, size);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-size, size, size);

        anim.SetBool("Walk", horizontalInput != 0);
    }

    
}
