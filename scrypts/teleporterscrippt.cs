using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterscrippt : MonoBehaviour
{
    [SerializeField] Transform tpposition;
    [SerializeField] GameObject wite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.transform.position = tpposition.position;
            StopAllCoroutines();
            StartCoroutine(ww());
        }
    }

    IEnumerator ww()
    {
        wite.SetActive(true);
        yield return new WaitForSeconds(1f);
        wite.SetActive(false);
    }
}
