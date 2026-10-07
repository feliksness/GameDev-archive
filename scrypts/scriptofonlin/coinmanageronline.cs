using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmanageronline : MonoBehaviour
{
    [SerializeField] Text coins;
    public int valu;
    void Start()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            valu = PlayerPrefs.GetInt("money");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        coins.text = valu.ToString();
        if (valu != 0 && valu != PlayerPrefs.GetInt("money"))
            PlayerPrefs.SetInt("money", valu);
        PlayerPrefs.Save();
    }
}
