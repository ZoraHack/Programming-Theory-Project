using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    [SerializeField] Vector3 offset = new Vector3(-1, 9, -19);

    // Update is called once per frame
    void LateUpdate()
    {
        CameraOffset();

    }

    void CameraOffset() // I am using abstraction by creating new higher-level method that can be reused
    {
        //Offset the camera behind the player by adding to the player's position

        transform.position = player.transform.position + offset;

    }
}
