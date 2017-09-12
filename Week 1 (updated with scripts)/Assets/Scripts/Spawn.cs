using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {


	//add game object for the inspector

	public GameObject go;
	// start spawning after... seconds
	public float StartAfter = 1f;
	//how often to spawn objects
	public float SpawnFrequency = .1f;


	// Use this for initialization
	void Start () {
		//do something every x seconds
		//1. what you want to repeat (as a function)
		//2. after how many seconds do you want to start using it
		//3. repeat every x seconds
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {


		//first, move the spawner

		//transform.position = new Vector3(Random.Range(-5f,5f), 3, Random.Range(-5f,5f));


		Instantiate (go, transform.position, Quaternion.identity);

		//print location of spawner object
		Debug.Log (transform.position);
	}
}
