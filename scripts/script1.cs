using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour 
{
	public int player = 2;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxis ("Horizontal") != 0)
			transform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * player * Time.deltaTime); 
	}
}