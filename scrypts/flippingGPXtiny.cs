using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class flippingGPXtiny : MonoBehaviour
{
    public AIPath path;
    public SpriteRenderer skinn;

    
   
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
   
}
