using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comprobarColor : MonoBehaviour {
	
	Text text;
	static public Color color1 = Color.grey;
	static public Color color2 = Color.grey;
	static public bool estaColor1;
	static public bool estaColor2;
	public GameObject humoCaldero;
	private bool cambiaColor = true;
	//private int colorCambio; //1 -> naranja, 2 --> violeta

	// Use this for initialization
	void Awake()
	{
		text = GetComponent <Text> ();
		text.text = "verde";
		text.color = Color.green;
	}
	
	// Update is called once per frame
	void Update () 
	{
		colorLiquido ();
	}

	void colorLiquido()
	{
		if (text.text == "verde") 
		{
			if(color1 == Color.yellow && color2 == Color.blue || color2 == Color.yellow && color1 == Color.blue)
			{
				GetComponent<AudioSource> ().Play ();
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.green;

				StartCoroutine(cambioColorCaldero(1));
			}
			else if(color1 != Color.yellow && color2 != Color.blue && color1 != Color.grey && color2 != Color.grey)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.white;
				color1 = Color.grey;
				color2 = Color.grey;
				estaColor1 = false;
				estaColor2 = false;
			}
		}

		if (text.text == "naranja") 
		{
			if(color1 == Color.yellow && color2 == Color.red || color2 == Color.yellow && color1 == Color.red)
			{
				GetComponent<AudioSource> ().Play ();
				humoCaldero.GetComponent<ParticleSystem>().startColor = new Color(1f, 0.45f, 0.07f);

				StartCoroutine(cambioColorCaldero(2));
			}
			else if(color1 != Color.yellow && color2 != Color.blue && color1 != Color.grey && color2 != Color.grey)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.white;
				color1 = Color.grey;
				color2 = Color.grey;
				estaColor1 = false;
				estaColor2 = false;
			}
		}

		if (text.text == "violeta") 
		{
			if(color1 == Color.blue && color2 == Color.red || color2 == Color.blue && color1 == Color.red)
			{
				GetComponent<AudioSource> ().Play ();
				humoCaldero.GetComponent<ParticleSystem>().startColor = new Color(0.50f, 0f, 0.50f);
				//cargar menu
				StartCoroutine(juegoCompletado ());
			}
			else if(color1 != Color.yellow && color2 != Color.blue && color1 != Color.grey && color2 != Color.grey)
			{
				humoCaldero.GetComponent<ParticleSystem>().startColor = Color.white;
				color1 = Color.grey;
				color2 = Color.grey;
				estaColor1 = false;
				estaColor2 = false;
			}
		}
	}

	IEnumerator juegoCompletado()
	{
		yield return new WaitForSeconds (4.0f);
		Application.LoadLevel("Menu 3D");
	}

	IEnumerator cambioColorCaldero(int color)
	{
		//cambiaColor = false;
		yield return new WaitForSeconds (2.0f);
		humoCaldero.GetComponent<ParticleSystem>().startColor = Color.white;
		color1 = Color.white;
		color2 = Color.white;
		estaColor1 = false;
		estaColor2 = false;
		//cambiaColor = true;

		switch (color) 
		{
			case 1:
				text.text = "naranja";
				text.color = new Color(1f, 0.64f, 0f);
				break;
			case 2:
				text.text = "violeta";
				text.color = new Color(0.50f, 0f, 0.50f);
				break;
		}
	}
}
