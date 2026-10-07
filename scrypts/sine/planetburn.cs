using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetburn : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject planet;
    GameObject P;
    float distance;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        P = Instantiate(planet, gameObject.transform);
    }

    private void FixedUpdate()
    {
        distance = Vector2.Distance(gameObject.transform.position, player.transform.position);
        if (distance > 200)
        {
            P.SetActive(false);  
        }
        if(distance < 180)
        {
            P.SetActive(true);
        }
    }

}
