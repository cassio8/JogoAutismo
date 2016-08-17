using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	private static int acertos;
	private static int erros;

	public Score()  {

		acertos = 0;
		erros = 0;

	}

	public static void incrementAcertos()  {
		acertos++;
	}

	public static void decrementAcertos()  {
		acertos--;
	}

	public static void incrementErros()  {
		erros++;
	}

	public static void decrementErros()  {
		erros--;
	}

	public static void Print()  {

		Debug.Log ("Acertos:" + acertos);
		Debug.Log ("Erros:" + erros);

	}

	public static int getErros()  {

		return erros;
	}

	public static int getAcertos()  {

		return acertos;
	}
}
