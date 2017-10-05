using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour {


	public Vector3 extrabounce;
	public float multiplier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision col){

		col.gameObject.GetComponent<Rigidbody> ().AddForce (extrabounce * multiplier);

	}


}
