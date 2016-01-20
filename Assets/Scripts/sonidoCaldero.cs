using UnityEngine;
using System.Collections;

public class sonidoCaldero : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		if (GetComponent<Transform> ().tag == "Caldero")
			GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
