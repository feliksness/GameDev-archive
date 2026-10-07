using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuch : MonoBehaviour
{
    [SerializeField] GameObject endd;
    private void OnTriggerStay2D(Collider2D red)
    {
        if(red.tag == "stayobject")
        {
            endd.GetComponent<end>().line();
            Debug.Log("nono");
        }
    }
}
