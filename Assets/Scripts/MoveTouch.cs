using UnityEngine;
using System.Collections;

public class MoveTouch : MonoBehaviour {

	// Use this for initialization
	public float speed;
	private bool verifica; //verifica se objeto esta sendo tocado

	void Start () {
	
		speed = 0.05f;
		verifica = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (verifica == true) {

			if (Input.touchCount == 1) {

				transform.Translate (Input.touches [0].deltaPosition.x * speed,
					Input.touches [0].deltaPosition.y * speed, 0);
			}

		}
	

	}

	void OnMouseDown()  { //clicou

		verifica = true;

	}

	void OnMouseUp()  { //soltou

		verifica = false;

	}
}
