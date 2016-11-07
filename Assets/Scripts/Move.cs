using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnGUI()  {

		foreach (Touch touch in Input.touches) {
			string texto = "";

			int num = touch.fingerId;

			GUI.Label (new Rect (0 + 130 * num, 0, 120, 100), texto);
		}

	}
}
