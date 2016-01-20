using UnityEngine;
using System.Collections;

public class cambiarColorHumo : MonoBehaviour {

	//public bool dentro = false;
	//public Rigidbody rb;
	public GameObject humoCaldero;
	
	
	// Use this for initialization
	void Awake () 
	{
 		//humoCaldero.GetComponent<ParticleSystem>(.
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Caldero") 
		{
			//si no hay ningun color todavia
			if(comprobarColor.estaColor1 == false)
			{ 
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.red;
				comprobarColor.estaColor1 = true;
				comprobarColor.color1 = Color.red;
			}
			else if(comprobarColor.estaColor1 == true && comprobarColor.estaColor2 == false)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.red;
				comprobarColor.estaColor2 = true;
				comprobarColor.color2 = Color.red;
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
