using UnityEngine;
using System.Collections;

public class cambiarHumoAmarillo : MonoBehaviour {

	//public bool dentro = false;
	//public Rigidbody rb;
	public GameObject humoCaldero;
	
	
	// Use this for initialization
	void Awake () 
	{
		//humoCaldero.GetComponent<ParticleSystem>(.
		//GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//reproducirSonido ();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Caldero") 
		{
			//si no hay ningun color todavia
			if(comprobarColor.estaColor1 == false)
			{ 
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.yellow;
				comprobarColor.estaColor1 = true;
				comprobarColor.color1 = Color.yellow;
			}
			else if(comprobarColor.estaColor1 == true && comprobarColor.estaColor2 == false)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.yellow;
				comprobarColor.estaColor2 = true;
				comprobarColor.color2 = Color.yellow;
			}
			else if(comprobarColor.estaColor1 == true && comprobarColor.estaColor2 == true)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.white;
				comprobarColor.estaColor1 = false;
				comprobarColor.estaColor2 = false;
				comprobarColor.color1 = Color.gray;
				comprobarColor.color2 = Color.gray;
				GetComponent<AudioSource> ().Play ();
			}
		}
	}
}
