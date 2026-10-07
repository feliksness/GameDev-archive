using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delit : MonoBehaviour
{
    [SerializeField] GameObject endd;
    [SerializeField] GameObject sp;
    [SerializeField] GameObject uimanagerr;
    private void OnTriggerEnter2D(Collider2D down)
    {
        if (down.tag == "fallingobject")
        {
           
            Destroy(down.gameObject);
            sp.GetComponent<spawn>().spawnbox();
            endd.GetComponent<end>().harm();
            Debug.Log("del");
        }
        if (down.tag == "stayobject")
        {
            uimanagerr.GetComponent<count>().minus();
            Destroy(down.gameObject);
            endd.GetComponent<end>().harm();
            Debug.Log("del");
        }
    }
}
