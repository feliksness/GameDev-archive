using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magdamag : MonoBehaviour
{
    public GameObject skelet;
    public GameObject activator;
    public GameObject attackone,attacktwo;
    public bool mayy;
    Vector2 mov;
    public int a;
    void Start()
    {
        mayy = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mov.x == 0 && mov.y == 0 && activator.GetComponent<Aiactivator>().reached == true && mayy == true)
        {
             a = Random.Range(0, 2);
            mayy = false;
            if (a == 0)
            {
                StartCoroutine(sec());
            }
            if (a == 1)
            {
                StartCoroutine(ses());
            }
        }
    }





    IEnumerator sec()
    {
        activator.GetComponent<Aiactivator>().Off();
        yield return new WaitForSeconds(0.5f);
        attackone.SetActive(true);
        yield return new WaitForSeconds(3f);
        attackone.SetActive(false);
        activator.GetComponent<Aiactivator>().On();
        yield return new WaitForSeconds(3f);
        mayy = true;
    }

    IEnumerator ses()
    {
        activator.GetComponent<Aiactivator>().Off();
        yield return new WaitForSeconds(1f);
        attacktwo.SetActive(true);
        GameObject at = Instantiate(skelet) as GameObject;
        at.transform.position = gameObject.transform.position;
        yield return new WaitForSeconds(1f);
        attacktwo.SetActive(false);
        activator.GetComponent<Aiactivator>().On();
        yield return new WaitForSeconds(3f);
        mayy = true;

    }

}
