using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour {

	public int tiv;
	public Text tx;

	void Start () {
		Randomtiv ();
	}
	

	void Randomtiv () {
		tiv = Random.Range (-100000000 ,100000000);
		Debug.Log (tiv);

	}
}
