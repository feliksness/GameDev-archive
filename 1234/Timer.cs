using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Timer : MonoBehaviour
{
	public TextMesh t;
	public Transform target;
	Vector3 oldpos;
	float time;
	void Start ()
	{
		oldpos = transform.position;
		t = GetComponent<TextMesh> ();
		time = 0;
	}
	

	void Update ()
	{
		
		transform.position = new Vector3(target.position.x + 4,target.position.y+4,transform.position.z);

		t.text = time +"";
		time += Time.deltaTime;
		
	}
}
