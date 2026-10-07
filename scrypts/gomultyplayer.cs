using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomultyplayer : MonoBehaviour
{
    public GameObject but;
    public GameObject player;
    public Animator anim;
    public GameObject clmag;

    bool endofshow;
    void Start()
    {
        
    }

    public void souldungeon()
    {
        but.SetActive(false);
       
        StartCoroutine(bbb());
    }

    IEnumerator bbb()
    {
        clmag.SetActive(true);
        anim.Play("govmulty");
        yield return new WaitForSeconds(3.5f);
        gameObject.GetComponent<loadlevel>().load();
    }


    
        
        

}
