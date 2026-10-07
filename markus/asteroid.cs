using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("IS Trigged");
		if (other.tag == "ground") {

			this.transform.position = new Vector2(Random.Range(-10.37f, 10f),Random.Range(18f,35f));
			Debug.Log (other.tag);		
		}
}
}