using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattackmag: MonoBehaviour
{
    public float damage;
    GameObject player;
    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            player.GetComponent<healthandother>().health = player.GetComponent<healthandother>().health - damage;
        }
        
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
