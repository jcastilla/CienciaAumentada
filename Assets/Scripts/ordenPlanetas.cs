using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ordenPlanetas : MonoBehaviour {

	public GameObject sol;
	public GameObject tierra;
	public GameObject jupiter;
	public GameObject neptuno;
	Text text;
	float posSol;
	float posTierra;
	float posJupiter;
	float posNeptuno;
	bool cambioColor = false;

	float posMarte;
	float posMercurio;
	float posVenus;
	public GameObject marte;
	public GameObject mercurio;
	public GameObject venus;

	void Awake()
	{
		text = GetComponent <Text> ();
		text.color = Color.red;

		//puntos = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		posSol = sol.GetComponent<Transform> ().position.x;
		posTierra = tierra.GetComponent<Transform> ().position.x;
		posJupiter = jupiter.GetComponent<Transform> ().position.x;
		posNeptuno = neptuno.GetComponent<Transform> ().position.x;

		posMarte = marte.GetComponent<Transform> ().position.x;
		posMercurio = mercurio.GetComponent<Transform> ().position.x;
		posVenus = venus.GetComponent<Transform> ().position.x;


		if (posSol > posMercurio && posMercurio > posVenus && posVenus > posTierra && posTierra > posMarte && posMarte > posJupiter && posJupiter > posNeptuno) 
		{
			//text.color = Color.green;
			//Application.LoadLevel("Menu 3D");
			StartCoroutine(juegoCompletado ());
		}

	}
	IEnumerator juegoCompletado()
	{
		text.color = Color.green;
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel("Menu 3D");
	}
}
