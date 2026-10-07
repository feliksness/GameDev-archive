using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oregeneration : MonoBehaviour
{
    int _seed;
    [SerializeField] GameObject[] Ore;
   
    void Start()
    {
        _seed = GameObject.FindGameObjectWithTag("SEEDManager").GetComponent<SEED>().seed;
        Random.InitState(_seed);

        generateore(oretypenum());
    }

    void FixedUpdate()
    {
      //  Debug.Log(oretypenum());
          
    }



    int oretypenum()
    {
        Random.InitState(_seed+(int)gameObject.transform.position.x-(int)(gameObject.transform.position.y/100));
        int a = Random.Range(0, 3);
        return a;
    }


    void generateore(int oretype)
    {
        switch (oretype)
        {
            case 0:
                borium(Random.Range(15,40));
                break;

            case 1:
                gold();
                break;

            case 2:
                ferium(Random.Range(8, 20));
                break;

        }
    }



    void borium(int num)
    {
        for(int i = 0; i < num; i++)
        {
            GameObject ore_ = Instantiate(Ore[0], gameObject.transform); //as GameObject;  gameObject.transform.position
            ore_.transform.position = new Vector3(gameObject.transform.position.x + (Random.Range(-10, 10) / 2), gameObject.transform.position.y + (Random.Range(-10, 10) / 2), gameObject.transform.position.z);
            ore_.transform.localScale = new Vector3(0.3f, 0.3f, 1);
            ore_.transform.Rotate(0, 0, Random.Range(0, 360));
        }
        
    }


    void gold()
    {
       
            GameObject ore_ = Instantiate(Ore[1], gameObject.transform); //as GameObject;  gameObject.transform.position
            ore_.transform.position = gameObject.transform.position*1.2f;
            ore_.transform.localScale = new Vector3(0.5f, 0.5f, 1);
           
    }

    void ferium(int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject ore_ = Instantiate(Ore[2], gameObject.transform); //as GameObject;  gameObject.transform.position
            ore_.transform.position = new Vector3(gameObject.transform.position.x + (Random.Range(-10, 10) / 2), gameObject.transform.position.y + (Random.Range(-10, 10) / 2), gameObject.transform.position.z);
            ore_.transform.localScale = new Vector3(0.05f, 2.3f, 1);
            ore_.transform.Rotate(0, 0, Random.Range(-20, 20));
        }

    }
}
