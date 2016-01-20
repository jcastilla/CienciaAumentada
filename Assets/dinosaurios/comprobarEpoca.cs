using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class comprobarEpoca : MonoBehaviour {

    public GameObject pterodactilo;
    public GameObject tiranosaurio;
    public GameObject braquiosaurio;
    public GameObject triasico;
    public GameObject cretacico;
    public GameObject jurasico;
    public GameObject textoTriasico;
    public GameObject textoCretacico;
    public GameObject textoJurasico;
    public GameObject informacionPteranodon;
    public GameObject informacionTiranosaurio;
    public GameObject informacionBraquiosaurio;
    public AudioSource sonidoPterodactilo;
    public AudioSource sonidoTiranosaurio;
    public AudioSource sonidoBraquiosaurio;
	private int cont = 0;

	// Use this for initialization
	void Start () {
        informacionPteranodon.SetActive(false);
        informacionTiranosaurio.SetActive(false);
        informacionBraquiosaurio.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () 
	{
        comprobar(pterodactilo,triasico,textoTriasico,informacionPteranodon);
        comprobar(tiranosaurio,cretacico,textoCretacico,informacionTiranosaurio);
        comprobar(braquiosaurio,jurasico,textoJurasico,informacionBraquiosaurio);

		if (textoTriasico.GetComponent<TextMesh> ().color == Color.green &&
			textoCretacico.GetComponent<TextMesh> ().color == Color.green &&
			textoJurasico.GetComponent<TextMesh> ().color == Color.green) 
		{
			StartCoroutine(juegoCompletado());
		}
        
	}

    void comprobar(GameObject dinosaurio,GameObject epoca, GameObject textoEpoca, GameObject informacion)
    {
        double diferencia_z = dinosaurio.GetComponent<Transform>().position.z - epoca.GetComponent<Transform>().position.z;
        double diferencia_x = dinosaurio.GetComponent<Transform>().position.x - epoca.GetComponent<Transform>().position.x;
        double diferencia_y = dinosaurio.GetComponent<Transform>().position.y - epoca.GetComponent<Transform>().position.y;
        if (diferencia_x >= -39 && diferencia_x <= 68)
        {
            //pterodactilo.GetComponent<AudioSource>().Play();
            textoEpoca.GetComponent<TextMesh>().color = Color.green;
            informacion.SetActive(true);

        }
        else
            //pterodactilo.GetComponent<AudioSource>().Stop();
            textoEpoca.GetComponent<TextMesh>().color = Color.red;

    }


	IEnumerator juegoCompletado()
	{
		yield return new WaitForSeconds (5.0f);
		Application.LoadLevel("Menu 3D");
	}
}
