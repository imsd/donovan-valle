﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {

	public Renderer rend;



	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void OnCollisionEnter  () {
			rend.material.color = Random.ColorHSV();
		}

	}

