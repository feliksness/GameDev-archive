using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {

	public Vector3 camPos;
	public Transform doodle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(doodle.position.y != camPos.y)
		{
			camPos.y = doodle.position.y;
			gameObject.transform.position = new Vector3(0, camPos.y,-6);

	}

}
}