using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectBehavior : MonoBehaviour {

	//variaveis globais
	public Text msg;
	public Text score;

	void Start () {

		msg.gameObject.SetActive (false);

	}

	void Update () {

	
		if (Score.getErros() == 5) {  //quantidade de erros para pular de fase

			Debug.Log ("Situacao Negativa");
			ControlBank.setErros (Score.getErros());
			//carregar proximo nivel, nesta situacao a fase nao foi positiva
			SceneManager.LoadScene("Level2");

		} else if (Score.getErros() == 0 && Score.getAcertos() == 3) {  //melhor caso, podemos pressupor que a criança, para este cenario, nao tem autismo

			Debug.Log ("Situacao Positiva");
			ControlBank.setErros (Score.getErros());
			SceneManager.LoadScene("Level2");

		} else if (Score.getErros() != 0 && Score.getAcertos() == 3) { //tem erros mas nao o suficiente para mudar de fase

			Debug.Log ("Situacao Media");
			ControlBank.setErros (Score.getErros());
			SceneManager.LoadScene("Level2");
		}

		Score.Print ();
	
	}

	IEnumerator OnCollisionEnter2D(Collision2D col)  {

		if (gameObject.name == "quadrado" && col.gameObject.name == "quadradoBuraco") {
			
			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();
		
			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);

		}

		if (gameObject.name == "triangulo" && col.gameObject.name == "trianguloBuraco") {

			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();

			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && col.gameObject.name == "circuloBuraco") {

			gameObject.transform.position = new Vector2(-4.72f, 7.36f);
			Score.incrementAcertos();
	
			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Você Acertou, Parabéns!";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "circulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "trianguloBuraco")) {

			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "quadrado" && (col.gameObject.name == "trianguloBuraco" || col.gameObject.name == "circuloBuraco")) {
			
			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

		if (gameObject.name == "triangulo" && (col.gameObject.name == "quadradoBuraco" || col.gameObject.name == "circuloBuraco")) {

			Score.incrementErros();
			msg.gameObject.SetActive (true);
			msg.alignment = TextAnchor.MiddleCenter;
			msg.text = "Tenho certeza que na próxima você irá melhor";
			yield return new WaitForSeconds(3);
			msg.gameObject.SetActive (false);
		}

	}
}
