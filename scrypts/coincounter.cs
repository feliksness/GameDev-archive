using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincounter : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "counter")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<healthandother>().coin++;
            Destroy(gameObject);
        }
    }
}
