using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFollow : MonoBehaviour {

	public Transform Player;

	void Update () {
		
		Vector3 toTarget = Player.transform.position - transform.position;

		this.transform.rotation = Quaternion.LookRotation (toTarget  ) ;

	}
}
