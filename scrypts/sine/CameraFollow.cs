using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float Z;
    public Transform Object_F;
    private Vector3 playerVector;
    [SerializeField] float speed;

    private void Start()
    {
        // Object_F = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Object_F.transform.position;
    }
   private void FixedUpdate()
    {
        
        if (Object_F != null)
        {
            playerVector = Object_F.position;
            playerVector.z = Z;
            transform.position = Vector3.Lerp(transform.position, playerVector, speed * Time.deltaTime);
        }
    }
}
