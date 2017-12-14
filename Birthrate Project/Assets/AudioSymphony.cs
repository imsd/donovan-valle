using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSymphony : MonoBehaviour{




	public AudioClip[] sounds;
	public GameObject particlesys; 

	private AudioSource audiosource;

	// Use this for initialization
	void Start () {

		audiosource = GetComponent<AudioSource>();
		int randnote = Random.Range (0, sounds.Length);
		audiosource.clip = sounds [randnote];
		//a note = sounds[0];
		//b note = sounds[1];

	}
	
	// Update is called once per frame
	void OnCollisionEnter () {
 		//if object collides with plane, or every time object gets instantiated, play random note from the "sounds" array.

		audiosource.Play();



		GameObject go = Instantiate (particlesys, transform.position, Quaternion.identity);
		Destroy (go, 3f);

		Destroy (this);

		Debug.Log (audiosource.clip);
	}
}
