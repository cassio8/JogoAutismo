using UnityEngine;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System.Collections.Generic;

public class ConexaoBanco : MonoBehaviour {

	private string source;
	private MySqlConnection conexao;
	private int i;
	private string t;
	private List<string> list = new List<string>();

	// Use this for initialization
	void Start () {

		source = "server = localhost;" +  //se por na web alterar aqui IP
			"Database = jogo;" +
			"User ID = root;" +
			"Pooling = false;"  +
			"Password =";

		conectarBanco(source);
		listar(conexao);
				 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void conectarBanco(string _source)  {

		conexao = new MySqlConnection(_source);
		conexao.Open();
	}

	void listar(MySqlConnection _conexao)  {

		MySqlCommand comando = _conexao.CreateCommand();
		comando.CommandText = "SELECT nome FROM paciente";
		MySqlDataReader dados = comando.ExecuteReader();

		while(dados.Read())  {

			string nome = (string)dados["nome"];

			list.Add (nome);

			Debug.Log ("nome:" + nome);

		}
			
	}
}
