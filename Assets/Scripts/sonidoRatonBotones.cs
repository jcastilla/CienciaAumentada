using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sonidoRatonBotones : MonoBehaviour {

	public GameObject boton;
	//public AudioClip sonido;

	public void reproducirSonido()
	{
		//boton.GetComponent<AudioSource> ().clip = sonido;
		boton.GetComponent<AudioSource> ().Play ();
	}
}
