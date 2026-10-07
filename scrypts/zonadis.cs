using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class zonadis : MonoBehaviour
{
    public float distance;
    public GameObject player;
    public SpriteRenderer sr;
    public byte a;
    public byte b;
    public byte g;
    public byte r;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distance = Vector2.Distance(player.transform.position, gameObject.transform.position);
        if(distance <= 70)
        {
            if (a <= 10) { sr.color = new Color32(r, g, b, a++); }
        }
        if (distance > 70)
        {
            if (a != 0) { sr.color = new Color32(r, g, b, a--); } 
        }

    }
}
