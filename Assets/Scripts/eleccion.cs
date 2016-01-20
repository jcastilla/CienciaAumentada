using UnityEngine;
using System.Collections;

public class eleccion : MonoBehaviour {

	public void Jugar()
	{
		Application.LoadLevel("planetas");
	}

	public void Creditos()
	{
		Application.LoadLevel("creditos");
	}

	public void Salir()
	{
		Application.Quit ();
	}
}