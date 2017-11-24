using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFollow : MonoBehaviour {

	public Transform Player;
	//public Transform astroid;

	// Update is called once per frame
	void Update () {
		
		Vector3 toTarget = Player.transform.position - transform.position;
		//float speed = 1.5f * Time.deltaTime;


		this.transform.rotation = Quaternion.LookRotation (toTarget  ) ;
		//transform.position += Player.transform.position;

		/*Vector3 dir = Player.transform.position - astroid.transform.position;

		if (dir.magnitude > 2f) {
			astroid.transform.rotation = Quaternion.Slerp (astroid.transform.rotation, Quaternion.LookRotation (dir), 20.0f * Time.deltaTime);

			astroid.transform.position += astroid.transform.forward * 20f * Time.deltaTime;
		}*/
	}

}
