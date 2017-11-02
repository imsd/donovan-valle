using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayStringExample : MonoBehaviour {

	public string[] names;
	public string[] occupations;
	public string[] occupations2;

	void Start () {
		// loop thru all the names
	//	for (int i = 0; i < names.Length; i++) {
	//		Debug.Log (names [i]);
	//	}


		//int rando = Random.Range (0, names.Length);
		//Debug.Log (names [rando]);

		int randNames = Random.Range (0, names.Length);
		int randOccupations = Random.Range (0, occupations.Length);
		int randOccupations2 = Random.Range (0, occupations2.Length);

		string line1 = "One Day, " + names [randNames] + 
			" wanted to be a " + occupations[randOccupations] + ", but instead, became a " +
			occupations2[randOccupations2] + ". Such is life.";

		Debug.Log (line1);
	}

	// Update is called once per frame
	void Update () {

	}
}