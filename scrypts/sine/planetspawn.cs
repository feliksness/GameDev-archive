using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetspawn : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] GameObject Planetselfmanger;

    [SerializeField] GameObject PointsofPlanetselfmanagers;

    Vector2 playerpos;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerpos = new Vector2(player.transform.position.x,player.transform.position.y);
     // poshunter(playerpos);
       spawnplanets(poshunter(playerpos),Planetselfmanger);
    }
    
    Vector3 poshunter(Vector2 playerposition)
    {
        Vector3 calc;
        
        calc = playerposition/1000;
        calc = new Vector2(Mathf.Round(calc.x), Mathf.Round(calc.y));
        calc = calc * 1000;
        calc.z = 10f;
       // Debug.Log(calc);
        return calc;
    }
    
   
    void spawnplanets(Vector3 poshunter_,GameObject PSM)
    {
       if(PointsofPlanetselfmanagers == null)
        {
            GameObject Planetseed = Instantiate(PSM);
            Planetseed.transform.position = poshunter_;
            PointsofPlanetselfmanagers = (GameObject)Planetseed;
        }
        else
        {
            if (PointsofPlanetselfmanagers.transform.position != poshunter_)
            {
                GameObject Planetseed = Instantiate(PSM);
                Planetseed.transform.position = poshunter_;
                Destroy(PointsofPlanetselfmanagers);
                PointsofPlanetselfmanagers = Planetseed;
            }
        }
          
    }
}
