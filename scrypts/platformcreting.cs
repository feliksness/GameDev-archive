using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformcreting : MonoBehaviour
{
    [SerializeField]GameObject[] columnes;
    void Start()
    {
        for(int i = 0; i < columnes.Length; i++)
        {
            int r;
            int t;
            r = Random.Range(-5,6);
            t = Random.Range(-13, -6);
            columnes[i].transform.position = new Vector2(r, t);
        }
    }

    
}
