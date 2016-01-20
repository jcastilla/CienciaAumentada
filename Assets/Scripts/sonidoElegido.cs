using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sonidoElegido : MonoBehaviour {

	//public GameObject boton;
	//public AudioClip sonido;
	
	public void reproducirSonido()
	{
		//boton.GetComponent<AudioSource> ().clip = sonido;
		GetComponent<AudioSource> ().Play ();
	}
}
