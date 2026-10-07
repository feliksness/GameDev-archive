using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class save : MonoBehaviour
{
    [SerializeField] AudioSource aus;
    [SerializeField] Text best;
    [SerializeField] Text last;
    int b;
    int l;
    [SerializeField] Animator an;
    void Start()
    {
        if (PlayerPrefs.HasKey("bs"))
        {
            b = PlayerPrefs.GetInt("bs");
        }
        if (PlayerPrefs.HasKey("ls"))
        {
            l = PlayerPrefs.GetInt("ls");
        }

        if (l > b)
        {
            b = l;
            PlayerPrefs.SetInt("bs", b);
            PlayerPrefs.Save();
        }


        best.text = b.ToString();
        last.text = l.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            StopAllCoroutines();
            StartCoroutine(i());
        }
    }

    IEnumerator i()
    {
        aus.Play();
        an.Play("closer");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }
}
