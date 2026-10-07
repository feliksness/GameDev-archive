using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthandother : MonoBehaviour
{
    public Scrollbar healthscrol;
    [Range(0,100)]public float health;

    public Scrollbar energyscrol;
    [Range(0, 100)] public float energy;

    public Text coins;
    public int coin;

    public Button heal;
    public Image healimage;

    public GameObject healanimationmanager;
    public Animator plhealing;




    void Start()
    {
        

        if (PlayerPrefs.HasKey("life"))
        {
            health = PlayerPrefs.GetFloat("life");
        }
        if (PlayerPrefs.HasKey("money"))
        {
            coin = PlayerPrefs.GetInt("money");
        }
        //playerprefsic hanel coin i arjeqy;
        StartCoroutine(updater());
    }

    public void Savec()
    {
        PlayerPrefs.SetInt("money", coin);
        PlayerPrefs.SetFloat("life",health);
        PlayerPrefs.Save();
    }
    private void OnApplicationQuit()
    {
        Savec();
    }

    void FixedUpdate()
    {

        if (energy > 100) { energy = 100; }
        if (energy < 0) { energy = 0; }

        if (health > 100) { health = 100; }
        if (health < 0) { health = 0; }
        
        healthscrol.size = health/100;
        energyscrol.size = energy/100;

        coins.text = coin.ToString();
    }


    IEnumerator updater()
    {
        Savec();
        yield return new WaitForSeconds(1f);
        energy = energy + 5f;
        health = health + 0.2f;
        StartCoroutine(updater());
    }

    IEnumerator healubd()
    {
        yield return new WaitForSeconds(5f);
        healimage.fillAmount = healimage.fillAmount + 0.1f;
        if (healimage.fillAmount != 1)
        {
            StartCoroutine(healubd());
        }
        else
        {
            healanimationmanager.SetActive(false);
            heal.interactable = true;
        }
    }

    public void ToHeal()
    {
        healanimationmanager.SetActive(true);
        plhealing.Play("healinganim");
        health = 100;
        StartCoroutine(healubd());
        healimage.fillAmount = 0;
        heal.interactable = false;

    }

}
