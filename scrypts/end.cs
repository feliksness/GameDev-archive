using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    [SerializeField] GameObject sp;
    [SerializeField] GameObject coun;
    public bool ended;
    [SerializeField] Scrollbar sb;
    public float health = 1;
    [SerializeField] GameObject red;
    [SerializeField] Animator anim;
    [SerializeField] Animator cl;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sb.size = health;
        if(health<= 0 && ended == false)
        {
            ended = true;
            StartCoroutine(e());
            
            
        }
        if (health > 1)
        {
            health = 1;
        }
        
    }

    public void harm()
    {
        anim.Play("harm");
        health = health - 0.4f;
    }

    public void line()
    {
        anim.Play("harm");
        health = -1;
    }

    IEnumerator e()
    {
        sp.GetComponent<spawn>().stop = true;
        cl.Play("closer");
        coun.GetComponent<count>().Save();
        yield return new WaitForSeconds(2f);
        for(float i = 1; i <= 0; i = i - 0.01f)
        {
            Time.timeScale = i;
        }
        SceneManager.LoadScene(0);

    }
}
