using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallchort : MonoBehaviour
{
    public GameObject boom;
    bool may = true;
    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponentInChildren<Aiactivator>().reached == true && may==true)
        {
            may = false;
            boom.SetActive(true);
            gameObject.GetComponentInChildren<enemylife>().health = -5;
            if (gameObject.GetComponentInChildren<enemylife>().distance <= 3)
            {
                 gameObject.GetComponentInChildren<enemylife>().player.GetComponent<healthandother>().health = gameObject.GetComponentInChildren<enemylife>().player.GetComponent<healthandother>().health - 20;
            }
        }
    }
}
