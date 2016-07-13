using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectBehavior : MonoBehaviour {

	// Use this for initialization
	public Text msg;
	public Text score;
	private int acertos; //numero maximo de acertos 3
	private int erros;

	void Start () {

		acertos = 0;
		erros = 0;
		msg.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		score.text = "Acertos: " + acertos;
	
	}

	IEnumerator OnCollisionEnter2D(Collision2D col)  {

		if (gameObject.name == "quadrado" && col.gameObject.name == "quadradoBuraco") {
			
			acertos++;
			transform.position = new Vector3(4.62f, -2.18f, 0);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);

		}

		if (gameObject.name == "triangulo" && col.gameObject.name == "trianguloBuraco") {

			acertos++;
			transform.position = new Vector3(2.47f, 1.56f, 0);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && col.gameObject.name == "circuloBuraco") {

			acertos++;
			transform.position = new Vector3(5.14f, 3.38f, 0);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "trianguloBuraco")) {

			erros++;
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "quadrado" && (col.gameObject.name == "trianguloBuraco" || col.gameObject.name == "circuloBuraco")) {

			erros++;
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "triangulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "circuloBuraco")) {

			erros++;
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}
			
	}
}
