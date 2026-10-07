using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tools : MonoBehaviour
{
    [SerializeField]Transform weaponpos;
    [SerializeField] GameObject standartbullet;
    bool isgooing;
    [SerializeField] AudioSource soundsofgun;
  [SerializeField]  AudioClip[] sounds;



    //laser
    [SerializeField] LineRenderer laserline;

    //
    void Start()
    {
        laserline = GameObject.FindGameObjectWithTag("Laser").GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            Shooting(standartbullet, 50, 0.2f, sounds[0]);
        }


        if (Input.GetKey(KeyCode.O))
        {
            laserline.enabled = true;
            Lasering(100f, weaponpos, laserline, sounds[1]);
        }
        else
        {
            laserline.enabled = false;
        }

           
        
    }


    void Shooting(GameObject BulletType , float bulletforce,float time,AudioClip soundofshot)
    {
        if (isgooing == false)
        {
            StartCoroutine(sec());
            IEnumerator sec()
            {
                Debug.Log("Shot");
                isgooing = true;

                //
                soundsofgun.clip = soundofshot;
                soundsofgun.Play();
                //
                GameObject AmoSpwn = Instantiate(BulletType, weaponpos.position, gameObject.transform.rotation);
                Rigidbody2D bulletbody = AmoSpwn.GetComponent<Rigidbody2D>();
                bulletbody.AddForce(weaponpos.up * bulletforce, ForceMode2D.Impulse);
                //
                Destroy(AmoSpwn, 5f);
                //
                yield return new WaitForSeconds(time);
                //
                isgooing = false;
            }
        }
    }

    void Lasering(float DefDistyanceRay , Transform LaserFirePoint , LineRenderer laserrenderer, AudioClip soundoflaser)
    {
       
        if (Physics2D.Raycast(gameObject.transform.position , gameObject.transform.up))
        {
            
            RaycastHit2D hit = Physics2D.Raycast(LaserFirePoint.transform.position, gameObject.transform.up);
            Draw2dRay(LaserFirePoint.position, hit.point);
            soundsofgun.clip = soundoflaser;
          
            if(soundsofgun.isPlaying == false)
            {
                soundsofgun.Play();
            }
           
        }
        void Draw2dRay(Vector2 startpos , Vector2 endpos)
        {
            laserrenderer.SetPosition(0, startpos);
            laserrenderer.SetPosition(1, endpos);
        }

        


    }
    


}
