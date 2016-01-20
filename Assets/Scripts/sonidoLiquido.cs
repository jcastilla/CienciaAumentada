using UnityEngine;
using System.Collections;

public class sonidoLiquido : MonoBehaviour {

	//public GameObject sonido;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<AudioSource> ().Play ();
	}
}
