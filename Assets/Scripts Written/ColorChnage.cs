﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChnage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		var main = this.GetComponent<ParticleSystem> ().main;
		main.startColor = new Color(1, 0, 1, 1);	
	}
}
