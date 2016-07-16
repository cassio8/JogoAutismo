using UnityEngine;
using System.Collections;

public class Encaixe : MonoBehaviour {

	// Use this for initialization
	private Animator anim;

	void Start () {
	
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col)  {

		if (gameObject.name == "quadradoBuraco" && col.gameObject.name == "quadrado") {

			anim.SetBool ("Alocar", true);
			col.gameObject.SetActive (false);

		}

		if (gameObject.name == "circuloBuraco" && col.gameObject.name == "circulo") {

			anim.SetBool ("Alocar", true);
			col.gameObject.SetActive (false);

		}

		if (gameObject.name == "trianguloBuraco" && col.gameObject.name == "triangulo") {

			anim.SetBool ("Alocar", true);
			col.gameObject.SetActive (false);

		}


	}
}
