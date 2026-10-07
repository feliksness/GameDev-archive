using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravityclock : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] int Timeofchangingdirection;
    bool isstarted;
    [SerializeField] GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Timegravitychanger());
        arrow.transform.localRotation = Quaternion.Euler(0, 120 * Player.GetComponent<Playermovemnt>().levelovgarvitydirection, 0);
    }

    IEnumerator Timegravitychanger()
    {
        isstarted = true;
        
        yield return new WaitForSeconds(Timeofchangingdirection);
        Player.GetComponent<Playermovemnt>().Switchgeroscope();
        Player.GetComponent<Playermovemnt>().worldGiroscope();
        isstarted = false;
        StartCoroutine(Timegravitychanger());
    }

    private void FixedUpdate()
    {
        arrow.transform.Rotate(0, 0.02f*120/(Timeofchangingdirection), 0);
    }
}
