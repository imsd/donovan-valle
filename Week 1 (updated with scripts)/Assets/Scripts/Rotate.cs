using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Vector 3 is a variable type that stores x, y and z info
	// we have to name the variable 
	public Vector3 my_Rotation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( my_Rotation * Time.deltaTime);
	}
}
