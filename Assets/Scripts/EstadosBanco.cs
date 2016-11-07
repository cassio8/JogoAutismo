using UnityEngine;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System.Collections.Generic;

public class EstadosBanco : MonoBehaviour {

	private static string source;
	private static MySqlConnection conexao;
	private static string nome;
	public static int estado;

	// Use this for initialization
	public EstadosBanco()  {


	}

	void Start () {

		source = "server = localhost;" +  //se por na web alterar aqui IP
			"Database = jogo;" +
			"User ID = root;" +
			"Pooling = false;"  +
			"Password =";
			
		conectarBanco(source);

	}

	// Update is called once per frame
	void Update () {

		//atualizarEstado(conexao);
	}

	static void conectarBanco(string _source)  {

		conexao = new MySqlConnection(_source);
		conexao.Open();
	}

	//recebe o estado da aplicacao
	public static void setEstado(int e)  {

		estado = e;
		Debug.Log ("Estado:" + estado);
		conectarBanco(source);
		atualizarEstado(conexao);
	}

	public static int getEstado()  {

		return estado;
	}

	public static void setNomeSessao()  {

		nome = ControlBank.getNome ();
		Debug.Log ("Nome:" + nome);
	}

	//atualiza o estado no banco para gerar as perguntas
	static void atualizarEstado(MySqlConnection _conexao)  {

		//conectarBanco(source);

		MySqlCommand comando = _conexao.CreateCommand();
		comando.CommandText = "UPDATE estado SET estado = '"+ estado +"', nome = '"+ nome +"' WHERE cod_estado = 1";
		MySqlDataReader dados = comando.ExecuteReader();

		dados.Close ();
	}
}
