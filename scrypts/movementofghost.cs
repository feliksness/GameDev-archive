using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class movementofghost : MonoBehaviour
{
    public Scrollbar updown;
   public float dirX, dirY;
    public float speed;
    PhotonView view;
    public Rigidbody2D rd;
    public GameObject skin;
    // Start is called before the first frame update
    void Start()
    {
        updown = GameObject.FindGameObjectWithTag("updown").GetComponent<Scrollbar>();
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            gameObject.tag = "Player";
        }
    }

    private void Update()
    {
        dirX = Input.acceleration.x * speed;
       if(updown.value > 0.5)
        {
            dirY = (2*updown.value - 1) * speed;
        }
        if (updown.value < 0.5)
        {
            dirY = -(1-2*updown.value) * speed;
        }
       if(updown.value == 0.5)
        {
            dirY = 0;
        }

    }
    void FixedUpdate()
    {
        if (updown.value != 0.5 && Input.touchCount == 0)
        {
            updown.value = 0.5f;
        }

        if (view.IsMine)
        {
            Vector2 til = new Vector2(dirX, dirY);
            rd.AddForce(til);


            if (dirX > 1f)
            {
                skin.transform.localScale = new Vector3(-1, 1, 1);
            }
            if (dirX < -1f)
            {
                skin.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}
