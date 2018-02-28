using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour {


	void OnCollision(Collision c)
	{
		if (c.gameObject.tag != "Player") 
		{
			Destroy (c.gameObject);
		}
	}
		
}
