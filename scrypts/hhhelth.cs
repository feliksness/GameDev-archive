using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hhhelth : MonoBehaviour
{
     GameObject aren;
   [SerializeField] GameObject boom;
     GameObject green;
    float distance;

    private void Start()
    {
        aren = GameObject.FindGameObjectWithTag("greenarena");
        green = GameObject.FindGameObjectWithTag("GreenBoss");
    }
    private void FixedUpdate()
    {
        distance = Vector2.Distance(gameObject.transform.position, green.transform.position);
        if(distance < 1)
        {
            aren.GetComponent<GreenBoss>().health = aren.GetComponent<GreenBoss>().health - 100;
            GameObject it = Instantiate(boom) as GameObject;
            it.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
    }

}
