using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour
{
    public Animator wpan;
    public Animator txt;
    public int wapon;
    public bool yn;
    public GameObject[] wp;

    public GameObject player;
    public float ene;

    public AudioSource sounds;
    public AudioClip[] clip;


    public GameObject hitt;
    public bool dd;
    public int dictancefordamage;

    int tim;
    bool invisact;
    void Start()
    {
        dictancefordamage = 0;
        dd = false;
        invisact = false;
        tim = 1;
        yn = false;
    }

    // Update is called once per frame
    void Update()
    {
        ene = player.GetComponent<healthandother>().energy;
        if ((Input.GetKeyDown(KeyCode.Space) == true || yn == true) && tim == 1 && invisact ==true)
        {
            StartCoroutine(timmer());
            if (wapon == 0)
            {
                if (ene > wapon)
                {

                    dd = true;
                    wpan.Play("knife");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - wapon;
                    sounds.clip = clip[3];
                    sounds.Play();
                    

                }
                else { textupdate(); }
            }

            if (wapon == 1)
            {
                if (ene > 5)
                {
                    dd = true;
                    sounds.clip = clip[1];
                    sounds.Play();

                    
                    wpan.Play("sword");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 10;
                    
                }
                else { textupdate(); }

            }

            if (wapon == 2)
            {
                if (ene > 20)
                {
                    dd = true;
                    wpan.Play("hummer");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 40;
                    sounds.clip = clip[0];
                    sounds.Play();
                }
                else { textupdate(); }
            }

            if (wapon == 3)
            {
                if (ene > 5)
                {
                    dd = true;
                    sounds.clip = clip[2];
                    sounds.Play();
                 
                    wpan.Play("sword");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 15;
                  
                }
                else { textupdate(); }

            }

            if (wapon == 4)
            {
                if (ene > 10)
                {
                    dd = true;
                    
                    wpan.Play("sword");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 25;
                    sounds.clip = clip[1];
                    sounds.Play();
                }
                else { textupdate(); }
            }

            if (wapon == 5)
            {
                if (ene > 12)
                {
                    dd = true;
                    
                    wpan.Play("bulava");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 12;
              
                }
                else { textupdate(); }
            }

            if (wapon == 6)
            {
                if (ene > 25)
                {
                    dd = true;
                    wpan.Play("magicwand");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 30;
                    sounds.clip = clip[5];
                    sounds.Play();
                }
                else { textupdate(); }
            }

            if (wapon == 7)
            {
                if (ene > wapon)
                {
                    dd = true;
                    wpan.Play("knife");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 8;
                    sounds.clip = clip[4];
                    sounds.Play();
                }
                else { textupdate(); }
            }

            if (wapon == 8)
            {
                if (ene > 15)
                {
                    dd = true;
                   
                    wpan.Play("sword");
                    player.GetComponent<healthandother>().energy = player.GetComponent<healthandother>().energy - 22;
                    sounds.clip = clip[1];
                    sounds.Play();
                }
                else { textupdate(); }
            }

            
        }
       





        yn = false;
    }

   
    // damgidistancy dnel bolor zenqeriny , bolor zenqeryi damagy linely kaxvac lini  heravorutyiunic;



    void clearrr()
    {
        for (int i = 0; i <9 ; i++)
        {
            wp[i].SetActive(false);
        }
    }


    public void hit()
    {
        yn = true;
    }

    public void knife0()
    {
        dictancefordamage = 1;
        hitt.GetComponent<weapondamage>().damage = 10;
        clearrr();
        wp[0].SetActive(true);
        wapon = 0;
        invisact = true;
    }
    public void sword1()
    {
        dictancefordamage = 3;
        hitt.GetComponent<weapondamage>().damage = 20;
        clearrr();
        wp[1].SetActive(true);
        wapon = 1;
        invisact = true;
    }
    public void hummer2()
    {
        dictancefordamage = 4;
        hitt.GetComponent<weapondamage>().damage = 40;
        clearrr();
        wp[2].SetActive(true);
        wapon = 2;
        invisact = true;
    }
    public void axe3()
    {
        dictancefordamage = 2;
        hitt.GetComponent<weapondamage>().damage = 30;
        clearrr();
        wp[3].SetActive(true);
        wapon = 3;
        invisact = true;
    }
    public void sw4()
    {
        dictancefordamage = 3;
        hitt.GetComponent<weapondamage>().damage = 45;
        clearrr();
        wp[4].SetActive(true);
        wapon = 4;
        invisact = true;
    }
    public void bulava5()
    {
        dictancefordamage = 2;
        hitt.GetComponent<weapondamage>().damage = 60;
        clearrr();
        wp[5].SetActive(true);
        wapon = 5;
        invisact = true;
    }
    public void wand6()
    {
        dictancefordamage = 5;
        hitt.GetComponent<weapondamage>().damage = 1;
        clearrr();
        wp[6].SetActive(true);
        wapon = 6;
        invisact = true;
    }
    public void sabla7()
    {
        dictancefordamage = 4;
        hitt.GetComponent<weapondamage>().damage = 70;
        clearrr();
        wp[7].SetActive(true);
        wapon = 7;
        invisact = true;
    }
    public void king8()
    {
        dictancefordamage = 3;
        hitt.GetComponent<weapondamage>().damage = 100;
        clearrr();
        wp[8].SetActive(true);
        wapon = 8;
        invisact = true;
    }

    
    void textupdate()
    {
        txt.Play("tartel");
    }

   ///////////////////////////////////////
  
   

   
    IEnumerator timmer()
    {
        tim = 0;
        yield return new WaitForSeconds(0.3f);
        tim = 1;
        if(wapon == 6)
        {
            dd = true;
            yield return new WaitForSeconds(3f);
            dd = false;
        }else
        {
            dd = false;
        }
    }

}
