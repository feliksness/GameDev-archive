using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattackbig : MonoBehaviour
{
    public GameObject wep;
    public GameObject activator;
    public Animator anim;
    public GameObject skinoriginal;
    public GameObject skinartif;
    public Animator ski;
    
    Vector2 mov;
    public string animationname;
    public string hitanimation;
    public string calmanim;
    public bool mayy;

    public AudioSource auso;

    private void Start()
    {
        mayy = true;
    }
    private void FixedUpdate()
    {
        if(wep.GetComponent<enemylife>().health > 1000)
        {
            skinoriginal.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
            skinartif.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
        }

        if (mov.x == 0 && mov.y == 0 && activator.GetComponent<Aiactivator>().reached == true && mayy == true)
        {
            mayy = false;
            StartCoroutine(sec());
        }


    }

    IEnumerator sec()
    {
        skinartif.SetActive(true);
        skinoriginal.SetActive(false);
        activator.GetComponent<Aiactivator>().Off();
        anim.Play(animationname);

        ski.Play(hitanimation);
        auso.Play();
        yield return new WaitForSeconds(2f);
        activator.GetComponent<Aiactivator>().On();
        ski.Play(calmanim);
        skinoriginal.SetActive(true);
        skinartif.SetActive(false);
        yield return new WaitForSeconds(5f);
        mayy = true;
    }

}
