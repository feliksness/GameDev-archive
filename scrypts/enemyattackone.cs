using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattackone : MonoBehaviour
{
    public int damage;
    GameObject player;
    private void OnTriggerEnter2D(Collider2D col)
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
