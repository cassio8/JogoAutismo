using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	// Use this for initialization
	public GameObject gerador;

	public AudioClip urso;
	public AudioClip carrinho;
	public AudioClip controle;
	public AudioClip videogame;
	public AudioClip cubo;

	private AudioSource audio;


	IEnumerator Start () {

		audio = GetComponent<AudioSource> ();

		gerador.SetActive (false);
		yield return new WaitForSeconds(15); //tela que aparece todos os objetos
		gerador.SetActive (true);
		gameObject.SetActive(false);
		EstadosBanco.setEstado (4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()  {

		if (gameObject.name == "controle") {
			Debug.Log ("Controle");

			audio.clip = controle;
			audio.Play ();
		}

		if (gameObject.name == "pelucia") {
			Debug.Log ("urso");

			audio.clip = urso;
			audio.Play ();
		}

		if (gameObject.name == "cubo") {
			Debug.Log ("Cubo");

			audio.clip = cubo;
			audio.Play ();
		}

		if (gameObject.name == "toy1") {
			Debug.Log ("Carro1");

			audio.clip = carrinho;
			audio.Play ();
		}

		if (gameObject.name == "toy2") {
			Debug.Log ("Carro2");

			audio.clip = carrinho;
			audio.Play ();
		}

		if (gameObject.name == "videogame") {
			Debug.Log ("Videogame");

			audio.clip = videogame;
			audio.Play ();
		}
	}
}
