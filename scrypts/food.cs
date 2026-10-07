using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public int a;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "counter")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<healthandother>().health = GameObject.FindGameObjectWithTag("Player").GetComponent<healthandother>().health + a;
            Destroy(gameObject);
        }
    }
}
