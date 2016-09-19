using UnityEngine;
using System.Collections;

public class MoveTouch : MonoBehaviour {

	// Use this for initialization
	public float speed;
	private bool verifica; //verifica se objeto esta sendo tocado

	void Start () {
	
		speed = 0.04f;
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

	//para testar no computador
	void OnMouseDrag()  {
		
		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


	}



}
