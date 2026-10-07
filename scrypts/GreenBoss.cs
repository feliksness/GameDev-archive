using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;

public class GreenBoss : MonoBehaviour
{
    [SerializeField] Button st;
    [SerializeField] Text comelater;
    [SerializeField] GameObject canofstart;
    [SerializeField] GameObject teleport;

    public GameObject die;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject skin;
    [SerializeField] GameObject Uicanv;
    [SerializeField] GameObject dm;
    public AIDestinationSetter dist;

    public Transform tp1;

    public Scrollbar hea;

    [SerializeField] GameObject bomb;

    float SysTime;

    float savetime;

    public GameObject player;
    public float health ;

    public GameObject boss;

    public int attack;
    //at 1
   public GameObject fog;
    public GameObject[] spawneenemyronudone;
   public GameObject[] sppointofenemyone;

    public GameObject lightt;

    public GameObject traps;

    //
    void Start()
    {
        if (PlayerPrefs.HasKey("savetimeofbossfight") == false)
        {
            PlayerPrefs.SetFloat("savetimeofbossfight", System.DateTime.Now.DayOfYear);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.HasKey("savetimeofbossfight"))
        {
            savetime = PlayerPrefs.GetFloat("savetimeofbossfight");
        }
       


        sppointofenemyone = GameObject.FindGameObjectsWithTag("sppointsofar1");
       // fight();
    }

    public void fight()
    {
        StartCoroutine(ff());
        boss.SetActive(true);
    }


    IEnumerator ff()
    {
        
        yield return new WaitForSeconds(10f);
        fog.SetActive(false);
        attacktwo();
        bombs();
        yield return new WaitForSeconds(33f);
        attack1();
      
        yield return new WaitForSeconds(20f);
        attack1();
        bombs();
        yield return new WaitForSeconds(20f);
        boss.transform.localScale = new Vector3(2, 2, 1);
        
        yield return new WaitForSeconds(30f);
        boss.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(ff());
    }
    void FixedUpdate()
    {
        hea.size = health / 3000;
        if (health <= 0)
        {
            
            dm.SetActive(false);
            Uicanv.SetActive(false);
            skin.SetActive(false);
            die.SetActive(true);
            StopAllCoroutines();
            health = 1000000;
            for (int i = 0; i <= 20; i++)
            {

                    GameObject at = Instantiate(coin) as GameObject;
                    at.transform.position = boss.transform.position;
            }
            for (int i = 0; i <= 1000; i++)
            {
                    player.GetComponent<healthandother>().coin++;
            }
           
            StartCoroutine(end());
        }

        if(player.GetComponent<dieandrespawn>().dead == true)
        {
            teleport.SetActive(true);
            StopAllCoroutines();
            dm.SetActive(false);
            Uicanv.SetActive(false);
            skin.SetActive(false);
            die.SetActive(true);
            canofstart.SetActive(true);
            boss.SetActive(false);
        }
    }

    public void attack1()
    {
        StartCoroutine(one());
        for (int i = 0; i < sppointofenemyone.Length; i++)
        {
            GameObject it = Instantiate(spawneenemyronudone[Random.Range(0, spawneenemyronudone.Length)]) as GameObject;
            it.transform.position = sppointofenemyone[i].transform.position;
            tp();
        }
    }
    private IEnumerator one()
    {

        fog.SetActive(true);
        yield return new WaitForSeconds(20f);
        fog.SetActive(false);
        pl();
     
    }
    void tp()
    {
        dist.target = tp1;
    }
    void pl()
    {
        dist.target = player.transform;
    }

    public void attacktwo()
    {
        StartCoroutine(two());
    }
    private IEnumerator two()
    {
        pl();
        lightt.SetActive(true);
        yield return new WaitForSeconds(32f);

        lightt.SetActive(false);

    }
   
    void bombs()
    {
         for (int i = 0; i < sppointofenemyone.Length; i++)
        {
            GameObject ot = Instantiate(bomb) as GameObject;
            ot.transform.position = sppointofenemyone[i].transform.position;
            
        }
    }
    
  public void timeandstart()
    {
        SysTime = System.DateTime.Now.DayOfYear;
        if (SysTime == savetime)
        {
            
            comelater.text = "You can fight only tomorrow!";
        }
        if(SysTime != savetime)
        {
            canofstart.SetActive(false);
            fog.SetActive(true);
            teleport.SetActive(false);
            fight();
            savetime = System.DateTime.Now.DayOfYear;
            PlayerPrefs.SetFloat("savetimeofbossfight", savetime);
            PlayerPrefs.Save();
        }
    }


    IEnumerator end()
    {
        yield return new WaitForSeconds(10f);
        fog.SetActive(true);
        yield return new WaitForSeconds(1f);
        teleport.SetActive(true);
        yield return new WaitForSeconds(10f);
        fog.SetActive(false);
    }
}
