using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roundmanager : MonoBehaviour
{
    bool predaxranitel;
    public bool youcanfinish;
    public int time;
    public GameObject[] Ienemys;
    public GameObject[] IIenemys;
    public Transform[] posofspawn;

    public GameObject main;

    GameObject[] enemys; 

    int second;
    
    public void Start0()
    {
        second = 0;
        predaxranitel = true;
        StartCoroutine(forsec());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        second++;
        if (second >= 50)
        {
            second = 0;
            if (youcanfinish == true && predaxranitel == true)
            {
                predaxranitel = false;
                enemys = GameObject.FindGameObjectsWithTag("Enemy");
                if (enemys.Length == 0)
                {
                        main.GetComponent<Arenamanagerscript>().end();
                        main.GetComponent<Arenamanagerscript>().save();
                }
                predaxranitel = true;

            }
        }

        if(main.GetComponent<Arenamanagerscript>().Player.GetComponent<dieandrespawn>().dead == true)
        {
            main.GetComponent<Arenamanagerscript>().roundnumber = 0;
            StopCoroutine(forsec());
            main.GetComponent<Arenamanagerscript>().deliteallenemys();
            youcanfinish = true;
            predaxranitel = true;
            
        }
    }

    public void spwanI()
    {
        for (int i = 0; i < Ienemys.Length; i++)
        {
            GameObject it = Instantiate(Ienemys[i]) as GameObject;
            it.transform.position = posofspawn[i].position;
        }
    }

    public void spwanII()
    {
        for (int i = 0; i < IIenemys.Length; i++)
        {
            GameObject at = Instantiate(IIenemys[i]) as GameObject;
            at.transform.position = posofspawn[i].position;
        }
    }

    public void stopcor()
    {
        StopCoroutine(forsec());
    }


    IEnumerator forsec()
    {
        spwanI();
        yield return new WaitForSeconds(time);
        spwanII();
        youcanfinish = true;
       
    }
}
