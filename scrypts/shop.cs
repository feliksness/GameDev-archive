using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public GameObject aren;
    public GameObject player;
    public GameObject shopui;

    public Image thatimage;

    public Text price;
    public Text Arenalevel;

    public Sprite[] sprite;

    public int au;

    public Button[] bt;

    public Button by;
    void Start()
    {
        shtk();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(au == 0) { thatimage.sprite = sprite[0]; }
    }

    public void onoff()
    {
        shopui.SetActive(!shopui.activeSelf);
        shtk();
    }

    public void sw1()
    {
        au = 1;
        thatimage.sprite = sprite[au];
        price.text = "Price - 200";
        Arenalevel.text = "Arena Level - 1";
        if (player.GetComponent<healthandother>().coin >= 200 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 1 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw2()
    {
        au = 2;
        thatimage.sprite = sprite[au];
        price.text = "Price - 3400";
        Arenalevel.text = "Arena Level - 2";
        if (player.GetComponent<healthandother>().coin >= 3400 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 2 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw3()
    {
        au = 3;
        thatimage.sprite = sprite[au];
        price.text = "Price - 12000";
        Arenalevel.text = "Arena Level - 4";
        if (player.GetComponent<healthandother>().coin >= 12000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 4 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw4()
    {
        au = 4;
        thatimage.sprite = sprite[au];
        price.text = "Price - 48000";
        Arenalevel.text = "Arena Level - 5";
        if (player.GetComponent<healthandother>().coin >= 48000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 5 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw5()
    {
        au = 5;
        thatimage.sprite = sprite[au];
        price.text = "Price - 52000";
        Arenalevel.text = "Arena Level - 6";
        if (player.GetComponent<healthandother>().coin >= 52000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 6 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw6()
    {
        au = 6;
        thatimage.sprite = sprite[au];
        price.text = "Price - 140000";
        Arenalevel.text = "Arena Level - 8";
        if (player.GetComponent<healthandother>().coin >= 140000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 8 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw7()
    {
        au = 7;
        thatimage.sprite = sprite[au];
        price.text = "Price - 60000";
        Arenalevel.text = "Arena Level - 10";
        if (player.GetComponent<healthandother>().coin >= 60000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 10 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void sw8()
    {
        au = 8;
        thatimage.sprite = sprite[au];
        price.text = "Price - 150000";
        Arenalevel.text = "Arena Level - 12";
        if(player.GetComponent<healthandother>().coin >= 150000 && aren.GetComponent<Arenamanagerscript>().Arenalevel >= 12 && player.GetComponentInChildren<inventory>().weaponlevel < au)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void slk1()
    {
        au = 9;
        thatimage.sprite = sprite[au];
        price.text = "Price - 1200";
        Arenalevel.text = "";
        if (player.GetComponent<healthandother>().coin >= 1200)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }
    public void slk2()
    {
        au = 10;
        thatimage.sprite = sprite[au];
        price.text = "Price - 1200";
        Arenalevel.text = "";
        if (player.GetComponent<healthandother>().coin >= 1200)
        {
            by.interactable = true;
        }
        else
        {
            by.interactable = false;
        }
    }

    public void Buy()
    {
        if(au == 1)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 200;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 2)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 3400;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 3)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 12000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 4)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 48000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 5)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 52000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 6)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 140000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 7)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 60000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 8)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 150000;
            player.GetComponentInChildren<inventory>().weaponlevel++;
        }
        if (au == 9)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 1200;
            player.GetComponentInChildren<EffectsonPlayer>().efint2++;
        }
        if (au == 10)
        {
            player.GetComponent<healthandother>().coin = player.GetComponent<healthandother>().coin - 1200;
            player.GetComponentInChildren<EffectsonPlayer>().efint3++;
        }
        shtk();
        player.GetComponent<healthandother>().Savec();
        player.GetComponentInChildren<inventory>().savee();
        player.GetComponentInChildren<EffectsonPlayer>().Savev();
    }

    void shtk()
    {
        for(int u = 0; u < bt.Length; u++)
        {
            if(u-1 < player.GetComponentInChildren<inventory>().weaponlevel)
            {
                bt[u].interactable = true;
            }
            else
            {
                bt[u].interactable = false;
            }
        }
    }

}
