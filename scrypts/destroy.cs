using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] float timeofdestroying;
    void Start()
    {
        StartCoroutine(timefordel());   
    }

    IEnumerator timefordel()
    {
        yield return new WaitForSeconds(timeofdestroying);
        Destroy(gameObject);
    }

}
