using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {

	public static float DistanceFromTarget;
	//distance from your target i.e if your far 42.4444 and if your close could be
	//2.1111 returns how far you are to your target
	public float ToTarget;


	// Update is called once per frame
	void Update () {
		RaycastHit Hit;
		//vector 3 is a way of defining a 3D world where you can define all directions in a 3D
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Hit)) {
			ToTarget = Hit.distance;
			//ToTarget will be equal to whatever the output is in the out Hit
			DistanceFromTarget = ToTarget;
		}
	}
}
