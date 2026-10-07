using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;
public class EffectsonPlayer : MonoBehaviour
{
    public GameObject ef0;
    public GameObject ef1;
    public GameObject ef2;
    public GameObject ef3;

    public int efint0;
    public int efint1;
    public int efint2;
    public int efint3;

    public Text[] eftext;
    public Text[] eftexttime;
    public GameObject[] sprite;

    public Button[] bt;

    public GameObject main;
    public GameObject inventory;

    public int[] a;


    public Light2D lt;

    public AudioSource aus;

    void Start()
    {
        if (PlayerPrefs.HasKey("ef0k"))
        {
            efint0 = PlayerPrefs.GetInt("ef0k");
        }
        if (PlayerPrefs.HasKey("ef1k"))
        {
            efint1 = PlayerPrefs.GetInt("ef1k");
        }
        if (PlayerPrefs.HasKey("ef2k"))
        {
            efint2 = PlayerPrefs.GetInt("ef2k");
        }
        if (PlayerPrefs.HasKey("ef3k"))
        {
            efint3 = PlayerPrefs.GetInt("ef3k");
        }

    }

  public void Savev()
    {
        PlayerPrefs.SetInt("ef0k", efint0);
        PlayerPrefs.SetInt("ef1k", efint1);
        PlayerPrefs.SetInt("ef2k", efint2);
        PlayerPrefs.SetInt("ef3k", efint3);
        PlayerPrefs.Save();
    }
    void FixedUpdate()
    {
        if(inventory.GetComponent<inventory>().inventoryisopen == true)
        {
            Savev();
        }
        eftext[0].text = efint0.ToString();
        eftext[1].text = efint1.ToString();
        eftext[2].text = efint2.ToString();
        eftext[3].text = efint3.ToString();
    }

    

    public void ef0void()
    {
        if (efint0 > 0)
        {
            efint0--;
            a[0] = 120;
            ef0.SetActive(true);
            StartCoroutine(ef0num());
            bt[0].interactable = false;
            aus.Play();
            Savev();
        }
    }


    public void ef1void()
    {
        if (efint1 > 0)
        {
            efint1--;
            a[1] = 120;
            ef1.SetActive(true);
            StartCoroutine(ef1num());
            bt[1].interactable = false;
            aus.Play();
            Savev();
        }
    }


    public void ef2void()
    {
        if (efint2 > 0)
        {
            efint2--;
            a[2] = 120;
            ef2.SetActive(true);
            StartCoroutine(ef2num());
            bt[2].interactable = false;
            aus.Play();
            Savev();
        }
    }


    public void ef3void()
    {
        if (efint3 > 0)
        {
            efint3--;
            a[3] = 120;
            ef3.SetActive(true);
            StartCoroutine(ef3num());
            bt[3].interactable = false;
            aus.Play();
            Savev();
        }
    }







    IEnumerator ef0num()
    {
        a[0]--;
        sprite[0].SetActive(true);
        eftexttime[0].text = a[0].ToString();
        main.GetComponent<healthandother>().energy = main.GetComponent<healthandother>().energy + 10;

        yield return new WaitForSeconds(1f);

        if (a[0] > 0)
        {
            StartCoroutine(ef0num());
        }
        else
        {
            sprite[0].SetActive(false);
            ef0.SetActive(false);
            bt[0].interactable = true;
        }
    }

    IEnumerator ef1num()
    {
        a[1]--;
        sprite[1].SetActive(true);
        eftexttime[1].text = a[1].ToString();
        main.GetComponent<healthandother>().health = main.GetComponent<healthandother>().health + 5;

        yield return new WaitForSeconds(1f);

        if (a[1] > 0)
        {
            StartCoroutine(ef1num());
        }
        else
        {
            sprite[1].SetActive(false);
            ef1.SetActive(false);
            bt[1].interactable = true;
        }
    }

    IEnumerator ef2num()
    {
        a[2]--;
        sprite[2].SetActive(true);
        eftexttime[2].text = a[2].ToString();
        main.GetComponent<playerMovemen>().speed = 6;

        yield return new WaitForSeconds(1f);

        if (a[2] > 0)
        {
            StartCoroutine(ef2num());
        }
        else
        {
            sprite[2].SetActive(false);
            ef2.SetActive(false);
            main.GetComponent<playerMovemen>().speed = 5;
            bt[2].interactable = true;

        }
    }

    IEnumerator ef3num()
    {
        a[3]--;
        sprite[3].SetActive(true);
        eftexttime[3].text = a[3].ToString();
        lt.pointLightOuterRadius = 20;

        yield return new WaitForSeconds(1f);

        if (a[3] > 0)
        {
            StartCoroutine(ef3num());
        }
        else
        {
            sprite[3].SetActive(false);
            ef3.SetActive(false);
            lt.pointLightOuterRadius = 10;
            bt[3].interactable = true;
        }
    }

    private void OnApplicationQuit()
    {
        Savev();
    }
}
