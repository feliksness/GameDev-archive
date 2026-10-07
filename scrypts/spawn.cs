using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public bool stop;
    [SerializeField] Transform sppoint;
    [SerializeField] GameObject[] figutres;
    void Start()
    {
        stop = false;
        spawnbox();
    }
    public void spawnbox()
    {
        if (stop == false)
        {


            GameObject it = Instantiate(figutres[Random.Range(0, figutres.Length)]) as GameObject;
            it.transform.position = sppoint.position;
        }
    }
}
