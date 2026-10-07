using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enviorenmentonoff : MonoBehaviour
{
    public GameObject player;
   public GameObject[] env;
    public float[] dist;
    public int spawn, despawn;
   
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        env = GameObject.FindGameObjectsWithTag("envi");
        
    }

   
    void FixedUpdate()
    {
        for(int i = 0; i < env.Length && player != null; i++)
        {
            dist[i] = Vector2.Distance(player.transform.position, env[i].transform.position);
            if (dist[i] >= despawn)
            {
                env[i].SetActive(false);
            }
            if (dist[i] <= spawn)
            {
                env[i].SetActive(true);
            }
        }
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

   
}
