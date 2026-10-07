using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 playerVector;
    public int speed;

    void FixedUpdate()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            
        }
        if (player != null)
        {
            playerVector = player.position;
            playerVector.z = -10;
            transform.position = Vector3.Lerp(transform.position, playerVector, speed * Time.deltaTime);
        }
      
    }
}
