using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectBehavior : MonoBehaviour {

	//variaveis globais
	public Text msg;
	public Text score;
	//private int acertos;
	//private int erros;
	//Score s = new Score();

	void Start () {

		//acertos = 0;
		//erros = 0;
		msg.gameObject.SetActive (false);
		//PlayerPrefs.SetInt ("Acertos", 0);

	}

	void Update () {

		//Debug.Log ("Erros: " + erros);
		//Debug.Log ("Acertos: " + acertos); //numero maximo a quantidade de formatos

		if (Score.getErros() == 5) {  //quantidade de erros para pular de fase

			Debug.Log ("Situacao Negativa");

			//carregar proximo nivel, nesta situacao a fase nao foi positiva
			SceneManager.LoadScene("Level2");

		} else if (Score.getErros() == 0 && Score.getAcertos() == 3) {  //melhor caso, podemos pressupor que a criança, para este cenario, nao tem autismo

			Debug.Log ("Situacao Positiva");
			SceneManager.LoadScene("Level2");

		} else if (Score.getErros() != 0 && Score.getAcertos() == 3) { //tem erros mas nao o suficiente para mudar de fase

			Debug.Log ("Situacao Media");
			SceneManager.LoadScene("Level2");
		}

		//score.text = "Acertos: " + PlayerPrefs.GetInt ("Acertos").ToString();
		Score.Print ();
	
	}

	IEnumerator OnCollisionEnter2D(Collision2D col)  {

		if (gameObject.name == "quadrado" && col.gameObject.name == "quadradoBuraco") {
			
			//acertos++;
			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();
			//gameObject.SetActive(false);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);

		}

		if (gameObject.name == "triangulo" && col.gameObject.name == "trianguloBuraco") {

			//acertos++;
			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();
			//gameObject.SetActive(false);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && col.gameObject.name == "circuloBuraco") {

			//acertos++;
			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();
			//gameObject.SetActive(false);
			msg.gameObject.SetActive (true);
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "trianguloBuraco")) {

			//erros++;
			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "quadrado" && (col.gameObject.name == "trianguloBuraco" || col.gameObject.name == "circuloBuraco")) {

			//erros++;
			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "triangulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "circuloBuraco")) {

			//erros++;
			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

	}
}
