using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] GameObject fx;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
           
          GameObject a = Instantiate(fx) as GameObject;
            a.transform.position = gameObject.transform.position;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Ore")
        {

            GameObject a = Instantiate(fx) as GameObject;
            a.transform.position = gameObject.transform.position;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }
}
