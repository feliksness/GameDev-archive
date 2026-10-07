using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionsave : MonoBehaviour
{
   
    float X, Y;
    public string XKeyname, YKeyname;
    void Start()
    {
        if (PlayerPrefs.HasKey(XKeyname) && PlayerPrefs.HasKey(YKeyname))
        {
            X = PlayerPrefs.GetFloat(XKeyname);
            Y = PlayerPrefs.GetFloat(YKeyname);
            gameObject.transform.position = new Vector2(X, Y);
        }
    }

    // Update is called once per frame
    public void Save()
    {
        X = gameObject.transform.position.x;
        Y = gameObject.transform.position.y;
        PlayerPrefs.SetFloat(XKeyname, X);
        PlayerPrefs.SetFloat(YKeyname, Y);
        PlayerPrefs.Save();
    }
    public void OnApplicationQuit()
    {
        Save();
    }
}
