using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpHealth : MonoBehaviour {

	public Image healthBar;
	private int counter = 0;
	private int counterMax = 50;

	// Use this for initialization
	void Start () {
		healthBar.fillAmount = 1f;

	}

	void GetDamage(float damage)
	{
		
		healthBar.fillAmount -= damage;
		if (healthBar.fillAmount == 0)
		{
			Die ();
		}
	}




	



	void GetHealth(float health)
	{
		healthBar.fillAmount += health;
	}


	void Die()
	{
		SceneManager.LoadScene ("Erste Scene3");
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "as") 
		{
			GetDamage (0.10f);
			Debug.Log ("no health");
		}

		if (other.gameObject.tag == "fa") 
		{
			SceneManager.LoadScene ("Win");
		}

		if (other.gameObject.tag == "gi") 
		{
		
			GetDamage (1.0f);
			Debug.Log ("no health");

		}
			if (other.gameObject.tag == "brett") {   
	
				GetHealth (1.0f);
				Debug.Log ("give health");

			}
	}

	IEnumerator WaitToDamage()
	{
		yield return new WaitForSeconds (0f);
		GetDamage (0.000005f);

	}

	// Update is called once per frame
	void Update () {
		StartCoroutine (WaitToDamage());
	}
}
