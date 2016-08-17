using UnityEngine;
using System.Collections;

public class GerarObjetos : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	private int c;  //verifica em qual animação foi clicado

	IEnumerator Start () {

		anim = GetComponent<Animator> ();

		anim.SetBool ("Trocar", true);
		c = 0;
		yield return new WaitForSeconds(5);
		anim.SetBool ("TrocarCubo", true);
		c = 1;
		Debug.Log("Entrou !");
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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()  {

		//Debug.Log ("Clicou!");

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
