using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [Range(0, 1)] public int controltype;
    [SerializeField] FloatingJoystick joystick;
    Quaternion rotsys;
    [SerializeField] Rigidbody2D rb;
    public Vector2 movement;
    public float speed;
    float dirx, diry;
    [SerializeField] ParticleSystem engineon;
    [SerializeField] bool PC;
    void Start()
    {
        engineon.Play();
        joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<FloatingJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        //inputzone

        if (PC == true)
        {
            joystick.gameObject.SetActive(false);
            dirx = Input.GetAxis("Horizontal");
            diry = Input.GetAxis("Vertical");
        }
        else
        {
            joystick.gameObject.SetActive(true);
            dirx = joystick.Horizontal;
            diry = joystick.Vertical;
        }
       
    }

    [System.Obsolete]
    private void FixedUpdate()
    {
        switch (controltype)
        {
            case 0:
                Move1();
                break;
            case 1:
                Move2();
                break;
        }
       

       
     

        
    }


    [System.Obsolete]
    void Move1()
    {
        movement = new Vector2(dirx, diry) * speed;
      

        rb.AddForce(movement);
        if (movement != Vector2.zero)
        {
            engineon.emissionRate = 10;
            engineon.playbackSpeed = 1;
            rotsys = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.forward, movement), speed);
            rb.MoveRotation(rotsys);
        }
        else
        {
            engineon.playbackSpeed = 1.5f;

            engineon.emissionRate = 0;
        }
    }

    void Move2()
    {
        if (diry > 0)
        {
            rb.AddForce(speed *gameObject.transform.up);
        }
        if (diry > 0 || dirx != 0)
        {
            engineon.emissionRate = 10;
            engineon.playbackSpeed = 1;
            gameObject.transform.Rotate(0, 0,-speed/3 * dirx);
            
        }
        else
        {
            engineon.playbackSpeed = 1.5f;

            engineon.emissionRate = 0;
        }
    }
}
