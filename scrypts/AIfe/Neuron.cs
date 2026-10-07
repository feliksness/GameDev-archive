using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;

public class Neuron : MonoBehaviour
{
    [SerializeField]int level = 0;

    bool doing;

    Transform spawnposition;
    float distance;
    Rigidbody2D rb;
    public float speedofrotation;
    [SerializeField] float jumpforce;

   [SerializeField] float timeofgoodjump;

   [SerializeField] Vector3 Dists ;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spawnposition = GameObject.FindGameObjectWithTag("sp").GetComponent<Transform>();
        timeofgoodjump = RRf(0,10);
        timeofgoodjump = (((RRf() / 100)));

       




    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distance = gameObject.transform.position.x - spawnposition.position.x;
        MoveRotRight();

        if(doing == false && level < 1000)
        {
            doing = true;
            StartCoroutine(ro());
           
        }
    }

    IEnumerator ro()
    {
        
       // Debug.Log("Ro");
        transformpos();
       // Debug.Log("sec" + jumpforce);
        yield return new WaitForSeconds(timeofgoodjump);
        Jump(jumpforce);
     //   Debug.Log("secfinish");
      //  Debug.Log("Round");
        yield return new WaitForSeconds(5f);
        Dists.y = Dists.x;
        Dists.x = distance;
        if (Dists.x < 13)
        {
            timeofgoodjump = timeofgoodjump + (RRf(-1000,1000)/1000);
            jumpforce = jumpforce + RRf(-100, 100);
        }
       if(Dists.x > Dists.y)
        {
            Dists.z = Dists.x;
        }

      //  Debug.Log("togj" + timeofgoodjump);
      //  Debug.Log("jf" + jumpforce);
        doing = false;

      //  Debug.Log("Rofinish");
      //  Debug.Log("Roundifciledone" + level);
        level++;
    }

    int RRi()
    {
        return (Random.Range(0, 1000));
    }
    float RRf()
    {
        return (Random.Range(100, 1000));
    }
    float RRf(float min , float max)
    {
        return (Random.Range(min, max));
    }


    void MoveRotRight()
    {
        gameObject.transform.Rotate(0, 0, -speedofrotation/3.14f);
        rb.AddForce(Vector2.right*speedofrotation);
    }

    void Jump(float jumpf)
    {
        for(int i = 0; i < 10; i++)
        {
            rb.AddForce(Vector2.up * jumpf);
        }
       // Debug.Log("Jumped");
    }


    

    void transformpos()
    {
        gameObject.transform.position = spawnposition.position;
    }


    
   
}
