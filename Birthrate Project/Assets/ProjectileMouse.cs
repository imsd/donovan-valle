using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMouse : MonoBehaviour {

	// how far, more or less, do you want it to go?
	public float distance = 10f;

	// how fast?
	public float power = 2000f;

	// Update is called once per frame
	void Update () {
		// on left click
		if (Input.GetMouseButtonDown(0)) {

		   
			GetComponent<Rigidbody>().AddForce(transform.forward * power);
		}
	}
}