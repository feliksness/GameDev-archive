using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traponoff : MonoBehaviour
{
    GameObject player;
   float distanse;
    public GameObject ban;
    public int spawn, despawn;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        distanse = Vector2.Distance(player.transform.position, gameObject.transform.position);
        if (distanse >= despawn)
        {
            ban.SetActive(false);
        }
        if (distanse <= spawn)
        {
            ban.SetActive(true);
        }
    }
}
