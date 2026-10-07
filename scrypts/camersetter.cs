using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class camersetter : MonoBehaviour
{
   [SerializeField] Canvas c;
    Camera ca;
    void Start()
    {
        ca = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        c = gameObject.GetComponent<Canvas>();
        c.worldCamera = ca;
    }

   
}
