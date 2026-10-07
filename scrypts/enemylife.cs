using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylife : MonoBehaviour
{
    
    public GameObject main;
    public int health;
    public GameObject[] detdparticles;
    public GameObject spawnitem;
    public AudioSource a;
    public float distance;
    public GameObject player;
    public int u;
    public bool may;
    void Start()
    {
        may = true;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(distance > 27)
        {
            Destroy(main);
        }

      


        u = player.GetComponent<attack>().dictancefordamage;
        distance = Vector2.Distance(main.transform.position,player.transform.position);

        if(distance < u && player.GetComponent<attack>().dd == true && may == true) 
        {
           StartCoroutine(sec());
               
                health = health - GameObject.FindGameObjectWithTag("weapon").GetComponent<weapondamage>().damage;
        }

       if(health<=0)
        {
            StartCoroutine(deth());
            health = 1000000;
        }
    }


    IEnumerator deth()
    {
        a.Play();
        main.GetComponentInChildren<Aiactivator>().Off();
        gameObject.GetComponent<Collider2D>().enabled = false;
       
        for (int i=0; i < detdparticles.Length; i++)
        {
            detdparticles[i].SetActive(true);
        }
        main.GetComponentInChildren<SpriteRenderer>().enabled = false;

        for (int i = 0; i <= Random.Range(1,8); i++)
        {
           GameObject it = Instantiate(spawnitem) as GameObject;
            it.transform.position = main.transform.position;
        }


        yield return new WaitForSeconds(1.5f);
        
        Destroy(main);
    }

    IEnumerator sec()
    {
        if(player.GetComponent<attack>().wapon == 6)
        {
            may = true;
        }
        else
        {
            may = false;
            yield return new WaitForSeconds(0.3f);
            may = true;
        }
    }


}
