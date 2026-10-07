using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Aiactivator : MonoBehaviour
{
    public AIDestinationSetter dd;
    public AIPath ai;
    public bool reached;
    public bool firststart;
    GameObject player;
    private void OnTriggerEnter2D(Collider2D unacceptablearea)
    {
        if(unacceptablearea.tag == "Player")
        {
            ai.enabled = true;
            firststart = true;
        }
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        dd.target = player.GetComponent<Transform>();
       if( ai.reachedDestination == true)
        {
            reached = true;
        }
        else
        {
            reached = false;
        }
    }

    public void On()
    {
        ai.enabled = true;
        
    }
    public void Off()
    {
        ai.enabled = false;
        
    }
}
