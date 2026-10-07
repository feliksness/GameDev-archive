using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Arenamanagerscript : MonoBehaviour
{
    public GameObject Player;

    public int Arenalevel;
    public Text Arenaleveltext;

    public bool isStarted;
    GameObject[] enemysfordeliting;

    public int roundnumber;
    public Text roundnumbertext;
    public Text activroundnumber;

    public GameObject button;


    public GameObject[] Round;


    public Animator wallopenclosanim;

    void Start()
    {
        if (PlayerPrefs.HasKey("AreLev"))
        {
            Arenalevel = PlayerPrefs.GetInt("AreLev");
            Arenaleveltext.text = Arenalevel.ToString();
        }
        //Arenalevelintiplayerprefsic hanely;

        Player = GameObject.FindGameObjectWithTag("Player");
        roundnumber = 0;
        activroundnumber.text = "Activate Round " + (roundnumber + 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(Player.GetComponent<dieandrespawn>().dead == true)
        {
            mer();
          
        }
    }

    public void Roundoffer()
    {
        for(int i =0;i<Round.Length;i++)
        {
            Round[i].SetActive(false);
        }
    }


    void mer()
    {
        end();
        deliteallenemys();
        roundnumber = 0;
        activroundnumber.text = "Activate Round " + (roundnumber + 1);
        if (PlayerPrefs.HasKey("AreLev"))
        {
            Arenalevel = PlayerPrefs.GetInt("AreLev");
        }
        Arenaleveltext.text = Arenalevel.ToString();
    }


    public void deliteallenemys()
    {
        enemysfordeliting = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0;i < enemysfordeliting.Length; i++)
        {
            Destroy(enemysfordeliting[i]);
        }

    }


    public void Go()
    {

        isStarted = true;
        Roundoffer();
        deliteallenemys();
        wallopenclosanim.Play("Arenawallopendoor");

        roundnumber++;
        roundnumbertext.text = "Round " + roundnumber;
        //////////////////////////
        Round[roundnumber-1].SetActive(true);
        Round[roundnumber - 1].GetComponent<Roundmanager>().stopcor();
        Round[roundnumber - 1].GetComponent<Roundmanager>().Start0();

    }


    public void end()
    {
        isStarted = false;
        Roundoffer();
        wallopenclosanim.Play("Arenawallclosedoor");
        if(Arenalevel < roundnumber) { Arenalevel = roundnumber; }
        Arenaleveltext.text = Arenalevel.ToString();
        if(roundnumber == 12) { roundnumber = 0; }
        activroundnumber.text = "Activate Round " + (roundnumber + 1);
        button.SetActive(true);

        
    }

    public void save()
    {
        PlayerPrefs.SetInt("AreLev", Arenalevel);
        PlayerPrefs.Save();
    }
}
