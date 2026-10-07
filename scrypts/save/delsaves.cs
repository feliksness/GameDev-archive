using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delsaves : MonoBehaviour
{
    public void cancesavedata()
    {
        PlayerPrefs.DeleteAll();
    }
}
