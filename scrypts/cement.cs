using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cement : MonoBehaviour
{
    [SerializeField] AudioSource aaa;
    private void OnTriggerEnter2D(Collider2D vvv)
    {
        if (vvv.tag == "fallingobject")
        {
            vvv.gameObject.GetComponent<block>().beton = true;
            Debug.Log("cement");
            aaa.Play();
            Destroy(this.gameObject);
        }
    }
}
