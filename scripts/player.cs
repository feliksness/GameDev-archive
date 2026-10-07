using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour 
{
	public int h;

	void Start () 
	{
		


	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("aaaaaaaa");
		if (other.tag == "Player") {
			
			gun.instance.distance += 10;


				
				Destroy (this.gameObject);
		}


	}

}	

