using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GerarObjetos : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	private int c;  //verifica em qual animação foi clicado

	public AudioClip urso;
	public AudioClip carrinho;
	public AudioClip controle;
	public AudioClip videogame;
	public AudioClip cubo;

	private AudioSource audio;

	IEnumerator Start () {

		audio = GetComponent<AudioSource> ();

		anim = GetComponent<Animator> ();

		anim.SetBool ("Trocar", true);
		c = 0;
		yield return new WaitForSeconds(5);
		anim.SetBool ("TrocarCubo", true);
		c = 1;
		yield return new WaitForSeconds(5);
		anim.SetBool ("TrocarUrso", true);
		c = 2;
		yield return new WaitForSeconds(5);
		anim.SetBool ("TrocarCarro1", true);
		c = 3;
		yield return new WaitForSeconds(5);
		anim.SetBool ("TrocarVideoGame", true);
		c = 4;
		yield return new WaitForSeconds(5);

		//outra cena
		SceneManager.LoadScene("Fim");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()  {

		//Debug.Log ("Clicou!");

		if (c == 0) {
			Debug.Log ("Controle");

			audio.clip = controle;
			audio.Play ();
		}

		if (c == 1) {
			Debug.Log ("cubo");

			audio.clip = cubo;
			audio.Play ();
		}

		if (c == 2) {
			Debug.Log ("urso");

			audio.clip = urso;
			audio.Play ();
		}

		if (c == 3) {
			Debug.Log ("Carro1");

			audio.clip = carrinho;
			audio.Play ();
		}

		if (c == 4) {
			Debug.Log ("VideoGame");

			audio.clip = videogame;
			audio.Play ();
		}
			
	}
}
