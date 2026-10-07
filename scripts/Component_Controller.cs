using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component_Controller : MonoBehaviour 
{
	Rigidbody rb;
	SphereCollider sc;
	Stats pl;
	void Start () 
	{
		pl = GameObject.FindWithTag ("Player").GetComponent<Stats>(); 
			
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (Vector3.forward*1100);
		sc = GetComponent<SphereCollider> ();
		sc.radius = 5;
		gameObject.name = "Klor";

	}

	float timer = 2;

	void Update () 
	{
		if (pl != null)
		{
			timer -= Time.deltaTime;
			if (timer <= 0)
			{
				pl.Damage (50);
				timer = 2;
			}
		}
	}
}
