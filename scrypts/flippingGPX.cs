using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class flippingGPX : MonoBehaviour
{
    public AIPath path;
    public SpriteRenderer skinn;
    public Animator flipper;
    public string playrun;
    public string playcalm;
    public GameObject hit2;
   
    void Update()
    {
        if(path.desiredVelocity.x > 0.1)
        {
            skinn.flipX = false;
           
        }
        if (path.desiredVelocity.x < -0.1)
        {
            skinn.flipX = true;
           
        }
        
    }
    private void FixedUpdate()
    {
        if (path.desiredVelocity.x != 0)
        {
            flipper.Play(playrun);
        }
        else
        {
                flipper.Play(playcalm);
        }
    }
}
