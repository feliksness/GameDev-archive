using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _HBS : MonoBehaviour
{
	Image img;
	PlayerStats pl;
	void Start () 
	{
		img = GetComponent<Image> ();
		pl = GameObject.FindWithTag ("Player").GetComponent<PlayerStats>();
	}
	float t = 0.05f;
	void Update () 
	{
		if (pl != null) 
		{
			img.fillAmount = pl.GetHealth () / pl.GetMaxHealth ();
			 
			t -= Time.deltaTime;
			if (t <= 0) 
			{
				pl.Damage (0.5f);
				t = 0.05f;
			}
		}

	}
}
