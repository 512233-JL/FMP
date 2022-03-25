using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{

    public bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        

        if(collision.tag == "Player")
        {
            
            if (Input.GetKey("e"))
            {
              
                SceneManager.LoadScene("Level 1");
            }
        }
        

    }
}
    


