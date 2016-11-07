using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization

	public Dropdown dd;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void jogar()  {

		Debug.Log (dd.captionText.text);
		Handheld.Vibrate();

		ControlBank.setNome (dd.captionText.text);

		EstadosBanco.setNomeSessao ();

		SceneManager.LoadScene ("Level1");

	}
}
