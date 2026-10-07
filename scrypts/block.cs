using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] GameObject way;
    GameObject soundofrotate;
    GameObject soundofdrop;
    GameObject uimanagr;
    public bool beton;
    GameObject manager;
    bool used = false;
   [SerializeField] float dirx;
    
    public bool rot = true;
    [SerializeField] bool testpc;
    int time;
    void Start()
    {
        //
        testpc = false;
        //
        gameObject.tag = "fallingobject";
        soundofrotate = GameObject.FindGameObjectWithTag("soundofrot");
        soundofdrop = GameObject.FindGameObjectWithTag("blocksound");
        uimanagr = GameObject.FindGameObjectWithTag("uimanager");
        manager = GameObject.FindGameObjectWithTag("spmanager");
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
            dirx = Input.acceleration.x;

        
        //if (testpc == true)
        //{
        //    dirx = Input.GetAxis("Horizontal") / 4;
        //}
        //else
        //{
        //}
        //


            if (time >= 10)
        {
            //0.5f
            if (dirx > 0.1f)
            {
                gameObject.transform.position = new Vector2(transform.position.x + 0.25f, gameObject.transform.position.y);
            }
            if (dirx < -0.1f)
            {
                gameObject.transform.position = new Vector2(transform.position.x - 0.25f, gameObject.transform.position.y);
            }
            if (dirx > 0.5f)
            {
                gameObject.transform.position = new Vector2(transform.position.x + 0.5f, gameObject.transform.position.y);
            }
            if (dirx < -0.5f)
            {
                gameObject.transform.position = new Vector2(transform.position.x - 0.5f, gameObject.transform.position.y);
            }


            time = 0;
        }

        if(gameObject.transform.position.x > 6f)
        {
            gameObject.transform.position = new Vector2(6f,transform.position.y);
        }
        if (gameObject.transform.position.x < -6f)
        {
            gameObject.transform.position = new Vector2(-6f, transform.position.y);
        }
        
        if (Input.touchCount > 0 && rot == true)
        {
            StartCoroutine(halfsec());
            rot = false;
           
            

        }


        time++;
    }

    IEnumerator halfsec()
    {
      
        soundofrotate.GetComponent<AudioSource>().Play();
        gameObject.transform.Rotate(0, 0, -30);
        way.transform.Rotate(0, 0, 30);
        yield return new WaitForSeconds(0.02f);
        gameObject.transform.Rotate(0, 0, -30);
        way.transform.Rotate(0, 0, 30);
        yield return new WaitForSeconds(0.02f);
        gameObject.transform.Rotate(0, 0, -30);
        way.transform.Rotate(0, 0, 30);
        yield return new WaitForSeconds(0.1f);

        rot = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (used == false)
        {
            used = true;

            gameObject.transform.SetParent(collision.transform.parent);
            if (beton == true)
            {

                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
            }
            Destroy(way);
            manager.GetComponent<spawn>().spawnbox();
            uimanagr.GetComponent<count>().plus();
            gameObject.tag = "stayobject";
            soundofdrop.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<block>().enabled = false;
        }
    }
}
