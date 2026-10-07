using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
   
    public Animator invi;
    public GameObject enven;


    public Text playerName;
    public Text floor;
    public string namestring;
    public GameObject inpt;
    public InputField namer;
    
    public int weaponlevel;
    public GameObject[] weapons;
    public bool inventoryisopen;


    void Start()
    {
        if (PlayerPrefs.HasKey("name"))
        {
            namestring = PlayerPrefs.GetString("name");
        }
        if (PlayerPrefs.HasKey("wpl"))
        {
            weaponlevel = PlayerPrefs.GetInt("wpl");
        }

        weponlevelchecker();
    }

   
    void FixedUpdate()
    {
        playerName.text = floor.text = namestring;
    }
    public void weponlevelchecker()
    {
        for (int i = 0; i < 9; i++)
        {
            weapons[i].SetActive(false);
        }
        for (int i = 0; i <= weaponlevel; i++)
        {
            weapons[i].SetActive(true);
        }
    }

    public void savee()
    {
        PlayerPrefs.SetString("name", namestring);
        PlayerPrefs.SetInt("wpl", weaponlevel);
        PlayerPrefs.Save();
    }


    public void Namee()
    {
       
        namestring = namer.text;
        playerName.text=floor.text=namestring;
        inpt.SetActive(false);
        savee();

    }
    public void closeinputter()
    {
        inpt.SetActive(!inpt.activeSelf);
    }
    public void openclose()
    {
        savee();
        weponlevelchecker();
        if (enven.activeSelf == false)
        {
            enven.SetActive(true);
            invi.Play("open");
            inventoryisopen = true;
        }
        else if (enven.activeSelf == true)
        {
            inventoryisopen = false;
            StartCoroutine(Secondes());
        }
    }

    IEnumerator Secondes()
    {
        invi.Play("close");
        yield return new WaitForSeconds(0.11f);
        enven.SetActive(false);
    }
}
