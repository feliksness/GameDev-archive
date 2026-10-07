using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SLoader1 : MonoBehaviour
{
    [SerializeField] Text loadinglevelprocnetage;
    [SerializeField] int index;
    AsyncOperation AsOp;
    private void Start()
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }



    private IEnumerator LoadScene_Coroutine(int _index)
    {
        AsOp = SceneManager.LoadSceneAsync(_index);
        AsOp.allowSceneActivation = false;//
        float progress = 0;

        while (!AsOp.isDone)
        {
           progress = AsOp.progress / 0.9f;
           loadinglevelprocnetage.text = (progress * 100).ToString() + "%";

            if(progress >= 0.9f)//
            {
                AsOp.allowSceneActivation = true;
            }//
         
            
           yield return 0;
        }
    }
}
