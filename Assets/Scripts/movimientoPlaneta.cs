﻿using UnityEngine;
using System.Collections;

public class movimientoPlaneta : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, -0.5f, 0);
	}
}
