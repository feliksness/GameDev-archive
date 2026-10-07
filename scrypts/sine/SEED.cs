using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEED : MonoBehaviour
{
    public int seed;
    void Start()
    {
        generateseed();
        //playerprefsic berel seed y 
        //1-in angam random generacnel;
    }

    void generateseed()
    {
        Random.InitState((int)(System.DateTime.Now.DayOfYear+System.DateTime.Now.Minute*System.DateTime.Now.Second));
        seed = Random.Range(1000000000, 2000000000);
    }
}
