﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour 
{
	void DestroyComponent()
	{
		Destroy(GetComponent<Rigidbody>());
	}
		
	void Update()
	{
		if (Input.GetButton("Fire1") && GetComponent<BoxCollider>())
		{
			Destroy(GetComponent<BoxCollider>());
		}
	}
}
