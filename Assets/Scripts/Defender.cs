﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
		void OnTriggerEnter2D()
		{
			Debug.Log(name + "trigger enter");
		}
	
}
