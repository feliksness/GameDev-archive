using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamobj : MonoBehaviour {

	public GameObject obj;
	public int[] number;
	public GameObject[] objarray;

	void Start () 
	{
		objarray = GameObject.FindGameObjectsWithTag ("cube");

		number = new int[10];
		number [0] = 12;
		obj = GameObject.FindGameObjectWithTag ("light");
		obj.SetActive (!obj.activeSelf);
		Destroy (objarray [2]);
	}
	

	void Update () {
		
	}
}
