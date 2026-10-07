using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public AudioSource aus;
    public Animator anim;
    bool hitmomenttrue;
    GameObject player;
    private void OnTriggerEnter2D(Collider2D trapcol)
    {
        if (trapcol.tag == "Player")
        {
            StartCoroutine(sec());
        }
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator sec()
    {
        if(hitmomenttrue== false)
        {
            hitmomenttrue = true;
            aus.Play();
           player.GetComponent<healthandother>().health = player.GetComponent<healthandother>().health - 20;
            anim.Play("trap");
            yield return new WaitForSeconds(1f);
            hitmomenttrue = false;
        }

        
    }
}
