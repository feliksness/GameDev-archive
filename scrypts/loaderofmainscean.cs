using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class loaderofmainscean : MonoBehaviour
{
    AsyncOperation asop;
   public int ScenID;
    public Text textofprogressvalue;
  

    void Start()
    {
        StartCoroutine(scenloading());
    }

    IEnumerator scenloading()
    {
        yield return new WaitForSeconds(1);
        asop = SceneManager.LoadSceneAsync(ScenID);
        while (!asop.isDone)
        {
            float progress = asop.progress / 0.9f;
           
            textofprogressvalue.text = (progress * 100).ToString() + "%";
            yield return 0;
        }
    }
}
