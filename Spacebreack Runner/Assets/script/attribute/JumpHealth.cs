using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	}



	/*if (healthBar.fillAmount == 0)
		{
			Die ();
		}*/
	



	void GetHealth(float health)
	{
		healthBar.fillAmount += health;
	}


	/*void Die()
	{

	}*/

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "as") 
		{
			GetDamage (0.10f);
			Debug.Log ("no health");
		}



		//if (counter == counterMax) {
			if (other.gameObject.tag == "brett") {   
				//counter++;
	
				GetHealth (1.0f);
				Debug.Log ("give health");
				//counter = 0;

			}
		//}
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
