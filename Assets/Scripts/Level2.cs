using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {

	// Use this for initialization
	public GameObject gerador;

	IEnumerator Start () {

		gerador.SetActive (false);
		yield return new WaitForSeconds(5); //tela que aparece todos os objetos
		gerador.SetActive (true);
		gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()  {

		if (gameObject.name == "controle") {
			Debug.Log ("Controle");
		}

		if (gameObject.name == "pelucia") {
			Debug.Log ("urso");
		}

		if (gameObject.name == "cubo") {
			Debug.Log ("Cubo");
		}

		if (gameObject.name == "toy1") {
			Debug.Log ("Carro1");
		}

		if (gameObject.name == "toy2") {
			Debug.Log ("Carro2");
		}

		if (gameObject.name == "videogame") {
			Debug.Log ("Videogame");
		}
	}
}
