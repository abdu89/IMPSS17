using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour {

	public float speed = 0.2F;
	// Use this for initialization
	void Start () {

		GameObject gaOb = GameObject.FindWithTag ("as");
		Vector3 v3 = (gaOb.transform.position - transform.position).normalized;

		Vector3 vv3 = new Vector3 (v3.x, v3.y, v3.z);
		GetComponent<Rigidbody> ().velocity = vv3 * speed;
	}

}
