using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	//public Text timerText;
	//private float startTime;
	//private bool click;
	public float minutes = 0;
	public float seconds = 0;
	private string time;
	// Use this for initialization
	void Start () {

		//click = false;
	}
	
	// Update is called once per frame
	void Update () {

		//if (click == true) {

			if (seconds >= 59) {

				seconds = 0;

				if (minutes <= 1) {

					minutes++;

				} else {

					minutes = 0;
					seconds = 0;
					//timerText.text = minutes.ToString() + ":" + seconds.ToString("f0");
				}

			} else {

				seconds += Time.deltaTime;
			}

			if (Mathf.Round (seconds) <= 9) {

				//Debug.Log (minutes.ToString () + ":0" + seconds.ToString ("f0"));
				time = minutes.ToString () + ":0" + seconds.ToString ("f0");

			} else {

				//timerText.text = minutes.ToString() + ":" + seconds.ToString("f0");
			}

			time = minutes.ToString () + ":" + seconds.ToString ("f0");
			//Debug.Log (minutes.ToString () + ":" + seconds.ToString ("f0"));

			ControlBank.setTempoResposta ("00:" + time); //formatar para o banco
	
		//}

	}
		
}
