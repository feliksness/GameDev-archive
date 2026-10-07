using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distancedeliter : MonoBehaviour
{
    GameObject player;
    float distanse;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        distanse = Vector2.Distance(player.transform.position, gameObject.transform.position);
        if(distanse > 30)
        {
            Destroy(gameObject);
        }
    }
}
