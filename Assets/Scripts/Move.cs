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

			/*texto += "ID: " + touch.fingerId + "\n";
			texto += "TapCount: " + touch.tapCount + "\n";
			texto += "phase: " + touch.phase.ToString() + "\n";
			texto += "Pos X " + touch.position.x + "\n";
			texto += "Pos Y " + touch.position.y + "\n";*/

			int num = touch.fingerId;

			GUI.Label (new Rect (0 + 130 * num, 0, 120, 100), texto);
		}

	}
}
