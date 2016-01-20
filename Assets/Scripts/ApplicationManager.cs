using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour {

	private int escena = 0;
	public GameObject musica;

	//void Awake() {
	//	DontDestroyOnLoad(musica);
	//}

	public void IniciarJuego()
	{
		escena = 1;
		//SceneManager.LoadScene ("IniciarJuego");
		//Application.LoadLevel("IniciarJuego");
		StartCoroutine(sonar ());
	}

	public void Creditos ()
	{

		escena = 2;
		//SceneManager.LoadScene ("Creditos");
		StartCoroutine(sonar ());
	}

	public void Atras ()
	{
		escena = 3;
		//SceneManager.LoadScene ("Menu 3D");
		//Application.LoadLevel("Menu 3D"");
		StartCoroutine(sonar ());
	}

	public void juego1() //ordenar planetas
	{
		escena = 4;
		StartCoroutine(sonar ());
	}

	public void juego2() //dinosaurios
	{
		escena = 5;
		StartCoroutine(sonar ());
	}

	public void juego3() //pociones
	{
		escena = 6;
		StartCoroutine(sonar ());
	}

	public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

	IEnumerator sonar()
	{
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (0.6f);
		switch (escena) 
		{
			case 1:
				Application.LoadLevel("IniciarJuego");
				break;
			case 2:
				Application.LoadLevel("Creditos");
				break;
			case 3:
				Application.LoadLevel("Menu 3D");
				break;
			case 4:
				Application.LoadLevel("explicacionPlanetas");
				break;
			case 5:
				Application.LoadLevel("explicacionDinosaurios");
				break;
			case 6:
				Application.LoadLevel("explicacionPociones");
				break;
		}
	}
}
