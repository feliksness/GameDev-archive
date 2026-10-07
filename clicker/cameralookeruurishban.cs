using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralookeruurishban : MonoBehaviour {
	public GameObject player000;

	private Vector3 a;
	// Use this for initialization
	void Start () {
		a = transform.position - player000.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player000.transform.position + a;
	}
}
