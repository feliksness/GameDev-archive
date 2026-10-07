using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedeliter : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(s());
    }

    IEnumerator s()
    {
        yield return new WaitForSeconds(60);
        Destroy(gameObject);
    }
   
}
