using UnityEngine;
using System.Collections;

public class ControlBank : MonoBehaviour  {

	private static string nome;
	private static int erros;
	private static int omissoes;
	private static string tempoResposta;

	// Use this for initialization
	public ControlBank () {

		/*nome = "Rivaldo";
		erros = 3;
		omissoes = 2;
		tempoResposta = "04:00";*/
	}

	public static void setNome (string n)  {

		nome = n;
	}

	public static void setErros (int e)  {

		erros = e;
	}

	public static void setOmissoes (int o)  {

		omissoes = o;
	}

	public static void setTempoResposta (string t)  {

		tempoResposta = t;
	}

	public static string getNome ()  {

		return nome;
	}

	public static int getErros ()  {

		return erros;
	}

	public static int getOmissoes ()  {

		return omissoes;
	}

	public static string getTempoResposta ()  {

		return tempoResposta;
	}
}
