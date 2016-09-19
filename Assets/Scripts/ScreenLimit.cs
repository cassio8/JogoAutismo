using UnityEngine;
using System.Collections;

public class ScreenLimit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		var pos = Camera.main.WorldToViewportPoint(transform.position);
		pos.x = Mathf.Clamp(pos.x, 0.05f, 0.95f);
		//pos.y = Mathf.Clamp(pos.y, 0.01f, 0.09f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);
	}
}

