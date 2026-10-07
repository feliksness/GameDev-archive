using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    [SerializeField] Text num;
    public int value;
    void Start()
    {
        value = 0;
    }

   
    void FixedUpdate()
    {
        num.text = value.ToString();
        if (value < 0)
        {
            value = 0;
        }
    }

    public void plus()
    {
        value++;
    }
    public void minus()
    {
        value--;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("ls", value);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}
