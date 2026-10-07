using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
	public static gun instance;
	public float distance;
	public ParticleSystem shot;
	public Camera fpsCam;
	public GameObject impactEffect;
	public float nextTimeShote;
	public float fireRate;
	void Start () 
	{
		distance = 100f;
		fireRate = 10f;
		instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetButton ("Fire1") && Time.time >= nextTimeShote) 
		
		{nextTimeShote = Time.time + 1 / fireRate;

			Shoot ();
		}



	}

	public void Shoot ()

	{
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit,distance))
		{
			Debug.Log (hit.transform.name);
		}
		if(hit.rigidbody!=null)
		{
			hit.rigidbody.AddForce (-hit.normal * 100);
		}
		shot.Play ();
		GameObject impact = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
		Destroy (impact, 0.3f);
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("aaaaaaaa");
		if (other.tag == "plus") 
		{
			if (distance == 0)
			distance += 100;
		}
	}
}
