using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qwertyuio : MonoBehaviour 
{
	public GameObject settings;
	public InputField imtext;

	void Start ()
	{

	}


	void Update ()
	{
		if (imtext.text == "time") {
			Application.LoadLevel (1);
		
		}
	}
}