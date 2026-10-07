using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savemanager : MonoBehaviour
{
    public GameObject[] saveogj;
    
    void FixedUpdate()
    {
        
            for(int i = 0; i<saveogj.Length;i++)
            {
                saveogj[i].GetComponent<positionsave>().Save();
            }
        
    }
}
