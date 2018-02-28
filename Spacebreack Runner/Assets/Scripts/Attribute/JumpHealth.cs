using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpHealth : MonoBehaviour {

	public Image healthBar;
	private int counter = 0;
	private int counterMax = 50;
	public GameObject playerDamage;
	public GameObject damagePanel;
	public GameObject healtPanel;

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
		SceneManager.LoadScene ("GameOver");
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "as") 
		{
			GetDamage (0.10f);
			Debug.Log ("VORSICHT!");
			//Panel anmachen
			damagePanel.SetActive (true);  
			//methode um auszuschalten 
			StartCoroutine (WaitToPanel());
		}
		if (other.gameObject.tag == "b") 
		{
			GetDamage (0.10f);
			Debug.Log ("VORSICHT!");
			//Panel anmachen
			damagePanel.SetActive (true);  
			//methode um auszuschalten 
			StartCoroutine (WaitToPanel());
		}

		if (other.gameObject.tag == "win2") 
		{
			SceneManager.LoadScene ("Win_2");
		}

        if (other.gameObject.tag == "fa")
        {
            SceneManager.LoadScene("Win");
        }

        if (other.gameObject.tag == "vorWand")
        {
            SceneManager.LoadScene("GameOver");
        }


        if (other.gameObject.tag == "gi") 
		{
		
			GetDamage (1.0f);
			Debug.Log ("no health");

		}
			if (other.gameObject.tag == "brett") {   
	
				GetHealth (1.0f);
				Debug.Log ("give health");
			//Panel anmachen
			healtPanel.SetActive (true);  

			//methode um auszuschalten 
			StartCoroutine (WaitToPanel1());
			}
	}

	IEnumerator WaitToDamage()
	{
		yield return new WaitForSeconds (0f);
		GetDamage (0.000005f);

	}

	void Update () {
		StartCoroutine (WaitToDamage());

	}

	//Methode um das DamagePanel wieder auszuschalten
	IEnumerator WaitToPanel()
	{
		yield return new WaitForSeconds (0.1f);
		damagePanel.SetActive (false);

	}

	//Methode um das HealthPanel wieder auszuschalten
	IEnumerator WaitToPanel1()
	{
		yield return new WaitForSeconds (0.1f);
		healtPanel.SetActive (false);

	}
	}
