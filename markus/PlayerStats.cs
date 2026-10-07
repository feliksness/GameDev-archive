using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour 
{
	private float health = 100,maxHealth = 100;
	public float GetHealth(){return health;}
	public float GetMaxHealth(){return maxHealth;}

	public void SetMaxHealth(float hp){maxHealth = hp;}

	void Death()
	{
		Debug.Log ("AAAAAAAA");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void Damage(float dmg)
	{
		health -= dmg;
		if (health <= 0)
			Death ();
	}
	public void Heal(float hp)
	{
		health = Mathf.Clamp (health + hp, 1, maxHealth); 
	}
}
