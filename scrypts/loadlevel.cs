using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
    public int a;
    public void load()
    {
        SceneManager.LoadScene(a);
    }
}
