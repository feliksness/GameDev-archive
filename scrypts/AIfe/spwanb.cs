using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spwanb : MonoBehaviour
{
    [SerializeField] GameObject He;
    [SerializeField] Scrollbar sc;
    [SerializeField] GameObject BOt;
    public int quantity;
    public float speed;
    [SerializeField]Slider[] slider;

    private void Start()
    {
        Rnd();
    }

    public void Rnd()
    {
        for (int i = 0; i < slider.Length; i++)
        {
            slider[i].value = Random.value;

        }
    }

    private void FixedUpdate()
    {
        speed = sc.value;
    }

    public void spawn()
    {
        for(int i = 0; i < quantity; i++)
        {
            GameObject a = Instantiate(BOt);
            a.GetComponent<Neuron>().speedofrotation = speed*200;
            a.GetComponent<SpriteRenderer>().color = new Color(slider[0].value, slider[1].value, slider[2].value, slider[3].value);
        }
       
    }

    public void hexagom()
    {
        He.SetActive(!He.activeSelf);
        He.transform.position = new Vector3(-2, 3, 0);
    }
}
