using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnofenemyinstart : MonoBehaviour
{
    GameObject player;
    float distance;
    public GameObject enemy;
    bool distanceisgood;
    GameObject arenamanager;
    void Start()
    {
        arenamanager = GameObject.FindGameObjectWithTag("arenamanager");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
       
       
        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
        if (distance >= 10 && Random.Range(0, 5) != 1 && 25 >= distance && distance >= 20 && distanceisgood == true && arenamanager.GetComponent<Arenamanagerscript>().isStarted == false)
        {
            spawnenemy();
        }

        if(distance > 30)
        {
            distanceisgood = true;
        }

    }

    void spawnenemy()
    {
        distanceisgood = false;
        GameObject spawnobject = Instantiate(enemy) as GameObject;
        spawnobject.transform.position = gameObject.transform.position;
    }
}
