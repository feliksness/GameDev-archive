using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zelka : MonoBehaviour
{
    public int tipe;

    private void OnTriggerEnter2D(Collider2D kkkk)
    {
        if (kkkk.tag == "counter")
        {
            if (tipe == 0) { GameObject.FindGameObjectWithTag("effectmanager").GetComponent<EffectsonPlayer>().efint0++; }
            if (tipe == 1) { GameObject.FindGameObjectWithTag("effectmanager").GetComponent<EffectsonPlayer>().efint1++; }
            if (tipe == 2) { GameObject.FindGameObjectWithTag("effectmanager").GetComponent<EffectsonPlayer>().efint2++; }
            if (tipe == 3) { GameObject.FindGameObjectWithTag("effectmanager").GetComponent<EffectsonPlayer>().efint3++; }

            Destroy(gameObject);
        }
    }

}
