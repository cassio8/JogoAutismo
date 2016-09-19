using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization

	public InputField name;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void jogar()  {

		Debug.Log (name.text);

		ControlBank.setNome (name.text);

		SceneManager.LoadScene ("Level1");

	}
}
