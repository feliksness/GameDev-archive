using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetgeneration : MonoBehaviour
{
    [SerializeField] GameObject motherOre;

    int _seed;
    [SerializeField] GameObject planet0;
    [SerializeField] GameObject planetcore;
    [SerializeField] GameObject planetaero;
    void Start()
    {
        _seed = GameObject.FindGameObjectWithTag("SEEDManager").GetComponent<SEED>().seed;

        Random.InitState(_seed + (int)gameObject.transform.position.x-((int)gameObject.transform.position.y/100));
       int scale = Random.Range(8, 15);

        byte color1 = (byte)Random.Range(0, 256);
        byte color2 = (byte)Random.Range(0, 256);
       byte color3 = (byte)Random.Range(0, 256);
        gameObject.transform.localScale = new Vector3(scale,scale);



        planet0.GetComponent<SpriteRenderer>().color = new Color32(color1, color2, color3, 255);
        planetcore.GetComponent<SpriteRenderer>().color = new Color32((byte)(color1-20), (byte)(color2-20), (byte)(color3-20), 255);
        planetaero.GetComponent<SpriteRenderer>().color = new Color32(color1, color2, color3, 10);

        spawnmotherores(Random.Range(0, 10));
    }

    void spawnmotherores(int num)
    {
        for(int i = 0; i < num; i++)
        {
           GameObject _Ore = Instantiate(motherOre, gameObject.transform);
            _Ore.transform.Rotate(0, 0, Random.Range(0, 360));
        }
      
    }
}
