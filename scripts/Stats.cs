using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
	public int hp = 100;
	void Start () 
	{
	/*	Debgger ();	
		Damage (20);
		int a = AgeCalc (1995, 2018);
		BirthdayCheck (5, 29, 6, 11);*/
	}

	void Debgger()
	{
		Debug.Log ("Time : " + Time.time);
		Debug.Log ("Delta Time : " + Time.deltaTime);
	}

	public void Damage(int dmg)
	{
		hp -= dmg;
		if (hp <= 0) 
			Destroy (this.gameObject);
	}
	int AgeCalc(int BYear,int CYear)
	{
		return CYear - BYear;
	}
		
	void BirthdayCheck(int bm,int bd,int cm,int cd)
	{
		if (cm > bm) 
			Debug.Log ("Passed");
			else if(cm == bm && cd>=bd)
					Debug.Log ("Passed");
				else
					Debug.Log ("Didn't Passed");

	}
}
