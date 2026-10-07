using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onlinechestscript : MonoBehaviour
{
    GameObject co;
    [SerializeField] GameObject breakingparticles;
    private void Start()
    {
        co = GameObject.FindGameObjectWithTag("manageronline");
    }
    private void OnTriggerEnter2D(Collider2D OP)
    {
        if(OP.tag == "Player")
        {
            co.GetComponent<coinmanageronline>().valu = co.GetComponent<coinmanageronline>().valu + Random.Range(20,40);
            gameObject.GetComponent<Collider2D>().enabled = false;
            breakingparticles.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
            StartCoroutine(t());
        }
    }

    IEnumerator t()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
