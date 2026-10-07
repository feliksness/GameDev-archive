using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestnormal : MonoBehaviour
{
    public int[] min, max; 
    public int[] lootadder;
    public GameObject particles;
    public GameObject[] items;
    bool may;
    private void Start()
    {
        may = true;
    }

    private void OnTriggerEnter2D(Collider2D entering)
    {
        if (entering.tag == "weapon" && may == true)
        {
            may = false;
            StartCoroutine(loot());
        }
    }
    IEnumerator loot()
    {


        particles.SetActive(true);
       GetComponentInChildren<SpriteRenderer>().enabled = false;

        for (int i = 0; i < items.Length; i++)
        {

            for (int a = 0; a < Random.Range(min[i], max[i]) * lootadder[i]; a++)
            {
                GameObject it = Instantiate(items[i]) as GameObject;
                it.transform.position = gameObject.transform.position;
            }
        }


        yield return new WaitForSeconds(1.5f);

        Destroy(gameObject);
    }
}
