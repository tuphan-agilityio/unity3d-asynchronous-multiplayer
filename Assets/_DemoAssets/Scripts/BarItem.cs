﻿using UnityEngine;
using System.Collections;

public class BarItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GameManager.GetInstance ().OnDragonCrashed ();
	}
}