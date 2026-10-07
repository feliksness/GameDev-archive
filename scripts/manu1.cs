using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manu1 : MonoBehaviour {
	public GameObject settings;

	public void lolllGame()
	{
		Application.LoadLevel (0);
	}
	public void LaungageGame()
	{
		Application.LoadLevel (2);
	}
	public void StartGame()
	{
		Application.LoadLevel (1);
	}
	public void StartGame1()
	{
		Application.LoadLevel (3);
	}
	public void StartGame2()
	{
		Application.LoadLevel (4);
	}
	public void Settings()
	{
		settings.SetActive (!settings.activeSelf);
	}

	public void Settings1()
	{
		settings.SetActive (!settings.activeSelf);
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	public void setMusic(float value)
	{
		global.musuc = value;
	}
}