using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStop : MonoBehaviour
{
    public GameObject cameraStopPosition;
    public CameraFollow cameraFollow;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x == cameraStopPosition.transform.position.x)
        {
           cameraFollow.FollowSpeed = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CameraStop")
        {
            cameraFollow.FollowSpeed = 0;
        }
    }
}
