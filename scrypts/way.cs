using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way : MonoBehaviour
{

    public GameObject waay;
    
    public TrailRenderer tr;

    public void waylookon()
    {
        
        waay.SetActive(false);
        tr.Clear();
        waay.transform.position = gameObject.transform.position;
        waay.SetActive(true);
       
        
    }
}
