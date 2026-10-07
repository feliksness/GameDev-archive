using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muscbackgroundsetter : MonoBehaviour
{
    public AudioSource backgroundmusic;
    void Start()
    {
        if(GameObject.FindGameObjectsWithTag("soundambient").Length > 1)
        {
            Destroy(this.gameObject);
        }
        backgroundmusic.volume = 0;
        backgroundmusic.time = Random.Range(0, 3700);
        StartCoroutine(buttery());

    }

    IEnumerator buttery()
    {
        while (backgroundmusic.volume <= 0.1)
        {
            backgroundmusic.volume = backgroundmusic.volume + 0.005f;
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
