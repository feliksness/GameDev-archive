using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager : MonoBehaviour 
{
	public Text timeHandler;
	void Start ()
	{
		timeHandler.color = new Color (0, 0, 0);
	}
	

	void Update () 
	{
		timeHandler.text = "Time : " + (int)Time.time;
	}
}
