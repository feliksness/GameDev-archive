using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovemen : MonoBehaviour
{
    public bool onoff;
    public float speed;
    public Rigidbody2D rb;
    public SpriteRenderer Skin;
    Vector2 movement;
    public Animator anim;
    public Transform handweapon;
    public Joystick joystick;
    public AudioSource au;


    void Update()
    {
        if (onoff == false)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        if(onoff == true)
        {
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
        }
        if (movement.x < 0)
        {
            Skin.flipX = true;
            handweapon.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (movement.x > 0)
        {
            Skin.flipX = false;
            handweapon.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        if (movement.x != 0 || movement.y !=0)
        {
            anim.Play("run");
            if (au.isPlaying == false)
            {
                au.Play();
            }
        }
        else
        {
            anim.Play("stop");
            au.Stop();
        }
        rb.MovePosition(rb.position + movement * speed*Time.fixedDeltaTime);
    }

    public void Pc()
    {
        onoff = false;
    }
    public void phone()
    {
        onoff = true;
    }
}
