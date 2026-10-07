using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovemnt : MonoBehaviour
{
    private float camrotY= 0f, camrotX = 0f;
    [SerializeField] Rigidbody rb;

    [SerializeField] float movementspeed,runspeed,walkspeed, jumpforce, sens,runacceleration, walkacceleration;
    
    [SerializeField] GameObject Cam;

    Vector3 MovementDirection;

    [SerializeField]int PlayerGarvity=0;

    [SerializeField] int parametrK;

    [SerializeField] bool X, Y, Z;
    public int levelovgarvitydirection;//"0x 1y 2z"

    bool t = true;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayerGarvity = 1;
       
        clearAllworldGiroscopeAxis();
        switch (levelovgarvitydirection)
        {
            case 0:
                clearAllworldGiroscopeAxis();
                X = true;
                break;
            case 1:
                clearAllworldGiroscopeAxis();
                Y = true;
                break;
            case 2:
                clearAllworldGiroscopeAxis();
                Z = true;
                break;
        }
    }
    private void FixedUpdate()
    {
       
        if (X)
        {
            MovementyOz();
        }
        if (Y)
        {
            MovementxOz();
        }
        if (Z)
        {
            MovementxOy();
        }

        if (Input.GetKey(KeyCode.F) && t == true)
        {
            PlayerGarvity = PlayerGarvity * (-1);
            parametrK = parametrK+180;
            if(parametrK == 360) { parametrK = 0; }
        
            StartCoroutine(pordz());
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementspeed = Mathf.Lerp(movementspeed, runspeed, Time.deltaTime * runacceleration);
        }
        else
        {
            movementspeed = Mathf.Lerp(movementspeed, walkspeed, Time.deltaTime * walkacceleration);
        }
       worldGiroscope();//?????? XYZ ???????????? ?????? ? ???????????
    }

    void Update()
    {
        Look();
    }

    void Look()
    {
        camrotX -= Input.GetAxisRaw("Mouse Y") * sens;
        camrotX = Mathf.Clamp(camrotX, -90f, 90f);
        camrotY += Input.GetAxisRaw("Mouse X") * sens;
        Cam.transform.localRotation = Quaternion.Euler(camrotX, camrotY, 0);
    }

    void MovementxOz()
    {
        Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal") )* movementspeed;
        Vector3 forward = new Vector3(-Cam.transform.right.z, 0f, Cam.transform.right.x)*PlayerGarvity;
        MovementDirection = (forward * axis.x + Cam.transform.right * axis.y + Vector3.up * rb.velocity.y);
        rb.velocity = MovementDirection;
        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(gameObject.transform.position, Vector3.down * PlayerGarvity, 1.005f))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpforce * PlayerGarvity, rb.velocity.z);
        }
        gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, Quaternion.Euler(0, 0, 0+parametrK), Time.deltaTime * 3);
    }

    void MovementyOz()
    {
        Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * movementspeed;
        Vector3 forward = new Vector3(0f,Cam.transform.right.z, -Cam.transform.right.y)*PlayerGarvity; 
        MovementDirection = (forward * axis.x + Cam.transform.right * axis.y + Vector3.right * rb.velocity.x);
        rb.velocity = MovementDirection;
        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(gameObject.transform.position, Vector3.left * PlayerGarvity, 1.005f))
        {
            rb.velocity = new Vector3(jumpforce * PlayerGarvity, rb.velocity.y, rb.velocity.z);
        }
        gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, Quaternion.Euler(0, 0, -90-parametrK), Time.deltaTime * 3);
    }

    void MovementxOy()
    {
        Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * movementspeed;
        Vector3 forward = new Vector3(Cam.transform.right.y, -Cam.transform.right.x,0 ) * PlayerGarvity;
        MovementDirection = (forward * axis.x + Cam.transform.right * axis.y + Vector3.forward * rb.velocity.z);
        rb.velocity = MovementDirection;
        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(gameObject.transform.position, Vector3.back * PlayerGarvity, 1.005f))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, jumpforce * PlayerGarvity);
        }
        gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, Quaternion.Euler(90 + parametrK, 0,0), Time.deltaTime * 3);
    }

    public void worldGiroscope()
    {
        if (X)
        { 
            Physics.gravity = new Vector3(-10, 0, 0) * PlayerGarvity; 
        }
        if (Y)
        {
            Physics.gravity = new Vector3(0, -10, 0) * PlayerGarvity; 
        }
        if (Z)
        { 
            Physics.gravity = new Vector3(0, 0, -10) * PlayerGarvity; 
        }
    }

    IEnumerator pordz()
    {
        t = false;
        yield return new WaitForSeconds(1f);
        t = true;
    }

    public void clearAllworldGiroscopeAxis()
    {
        X = false;
        Y = false;
        Z = false;
    }

    public void Switchgeroscope()
    {
        levelovgarvitydirection++;
        if(levelovgarvitydirection >= 3)
        {
            levelovgarvitydirection = 0;
        }
        switch (levelovgarvitydirection)
        {
            case 0:
                clearAllworldGiroscopeAxis();
                X = true;
                break;
            case 1:
                clearAllworldGiroscopeAxis();
                Y = true;
                break;
            case 2:
                clearAllworldGiroscopeAxis();
                Z = true;
                break;
        }
    }
}
