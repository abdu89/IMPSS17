using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpHealth_endBoss : MonoBehaviour {

	public Image healthBar_endBoss;
	private int counter = 0;
	private int counterMax = 50;
	public GameObject playerDamage_endBoss;
	public GameObject damagePanel_endBoss;
	public GameObject healthPanel_endBoss;


	// Use this for initialization
	void Start () {
		healthBar_endBoss.fillAmount = 1f;
	}

	void GetDamage(float damage_endboss)
	{
		
		healthBar_endBoss.fillAmount -= damage_endboss;
		if (healthBar_endBoss.fillAmount == 0)
		{
			Die ();
		}


	}




	



	void GetHealth(float health_endBoss)
	{
		healthBar_endBoss.fillAmount += health_endBoss;
	}


	void Die()
	{
		SceneManager.LoadScene ("EndWin");
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "bull") 
		{
			GetDamage (0.03f);
		//	Instantiate (playerDamage, transform.position, Quaternion.Euler (new Vector3 (0,0 , 0)));
			Debug.Log ("VORSICHT!");
			//Panel anmachen
			damagePanel_endBoss.SetActive (true);  
			//methode um auszuschalten 
			StartCoroutine (WaitToPanel());
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

	//Methode um das DamagePanel wieder auszuschalten
	IEnumerator WaitToPanel()
	{
		yield return new WaitForSeconds (0.1f);
		damagePanel_endBoss.SetActive (false);

	}

	//Methode um das HealthPanel wieder auszuschalten
	IEnumerator WaitToPanel1()
	{
		yield return new WaitForSeconds (0.1f);
		healthPanel_endBoss.SetActive (false);

	}
	}
