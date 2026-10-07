using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManager1 : MonoBehaviour 
{
	public Text mek;
	public InputField imtext;

	void Start ()
	{
		
	}
	

	void Update () 
	{
		if (imtext.text == "barev") {
			mek.text = "barev :D";
		} else if (imtext.text == "paka") {
			mek.text = "hajox";
		} else if (imtext.text == "inch ka") {
			mek.text = "vochinch";
		} else if (imtext.text == "paka") {
			mek.text = "eeeee";
		} else if (imtext.text == "anunt inch a") {
			mek.text = "MARKUS";
		} else if (imtext.text == "im anun y ") {
			mek.text = "hacheli a";
		} else if (imtext.text == "vonc es") {
			mek.text = "lav du vonc es";
		} else if (imtext.text == "lav") {
			mek.text = "..............";
		} else if (imtext.text == "vat") {
			mek.text = ":(";
		} else if (imtext.text == "voch vat") {
			mek.text = ":/";
		} else if (imtext.text == "...") {
			mek.text = "...";
		} else if (imtext.text == ":D") {
			mek.text = ":D :D :D :D";
		} else if (imtext.text == "hajox") {
			mek.text = "hajox";
		} else if (imtext.text == "markus") {
			mek.text = "ha";
		} else if (imtext.text == "MARKUS") {
			mek.text = "ha";
		} else if (imtext.text == "mihat asa anunt") {
			mek.text = "che da gaxtniq a";
		} else if (imtext.text == "gna") {
			mek.text = "dzeznic heto";
		} else if (imtext.text == "apush") {
			mek.text = "...du es";
		} else if (imtext.text == "debil") {
			mek.text = "...................:(";
		} else if (imtext.text == "ov a qez stextel") {
			mek.text = "Feliks Y";
		} else if (imtext.text == "Google") {
			mek.text = "ha inch?";
		} else if (imtext.text == "Yandex") {
			mek.text = "??????";
		} else if (imtext.text == "secret words") {
			mek.text = "music";
		} else {
			mek.text = "...";
		}






























	}
}
