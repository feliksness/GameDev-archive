using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tinychestgeneral : MonoBehaviour
{
    public GameObject home;
    public bool y;
    public Animator a;
    public GameObject particles;
    public GameObject Tiny;
    public AudioClip[] audioclip;
    public AudioSource aus;
    void Start()
    {
        //save anel positiony;

        
        
    }

    private void OnTriggerEnter2D(Collider2D kpav)
    {
        if (kpav.tag == "pp")
        {
            y = true;
            a.Play("chestopen");
            particles.SetActive(true);
            Tiny.transform.position = gameObject.transform.position;
            Tiny.SetActive(true);
            aus.clip = audioclip[0];
            aus.Play();
        }

    }

    private void OnTriggerExit2D(Collider2D kpav)
    {
        if (kpav.tag == "pp")
        {
            y = false;
            a.Play("chestclose");
            particles.SetActive(false);
            Tiny.SetActive(false);
            aus.clip = audioclip[1];
            aus.Play();
        }

    }


  

}
