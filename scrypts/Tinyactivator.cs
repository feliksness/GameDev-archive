using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Tinyactivator : MonoBehaviour
{
    public AIDestinationSetter dd;
    public AIPath ai;
    GameObject player;
    private void FixedUpdate()
    {
        dd.target = player.GetComponent<Transform>();
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
