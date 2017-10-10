
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardgeneral : MonoBehaviour {

	public GameObject go;
	public GameObject go2;	// second type of game object to spawn
	public float ForwardPower = 1f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey("up")) {
			// create a physics cube when A key is pressed
			transform.position += Vector3.forward * ForwardPower;

			Debug.Log ("key down");
		}

		if (Input.GetKeyDown("space")) {
			// create a phys sphere when spacebar is hit
			Instantiate (go2, transform.position, Quaternion.identity);
		}

	}
}