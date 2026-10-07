using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieandrespawn : MonoBehaviour
{

    public GameObject effects;
    public Transform basa;
    bool may;
    public playerMovemen pm;
    public Animator bl;
    public bool dead;
    void Start()
    {
        may = true;
        basa = GameObject.FindGameObjectWithTag("Basa").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<healthandother>().health < 1 && may == true)
        {
            may = false;
            StartCoroutine(die());
        }
    }


    IEnumerator die()
    {
        
        dead = true;
        pm.enabled = false;
       
        bl.Play("ekranofdie");
        effects.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        pm.enabled = true;
        gameObject.transform.position = basa.transform.position;
        gameObject.GetComponent<healthandother>().health = 70;
        yield return new WaitForSeconds(1f);
        effects.SetActive(false);
        yield return new WaitForSeconds(1f);
        dead = false;
        may = true;
    }
}
