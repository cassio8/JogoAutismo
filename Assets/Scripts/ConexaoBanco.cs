using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System.Collections.Generic;

public class ConexaoBanco : MonoBehaviour {

	/*private string source;
	private MySqlConnection conexao;
	public Text textRanking;
	private int i;
	private string t;
	private List<string> list = new List<string>();

	// Use this for initialization
	void Start () {

		source = "server = localhost;" +  //se por na web alterar aqui IP
			"Database = rankingboina;" +
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
		//comando.CommandText = "SELECT * FROM Ranking";
		comando.CommandText = "SELECT * FROM Ranking ORDER BY recorde DESC LIMIT 10";
		MySqlDataReader dados = comando.ExecuteReader();

		while(dados.Read())  {

			string nome = (string)dados["nome"];
			string curso = (string)dados["curso"];
			string recorde = dados["recorde"].ToString();

			list.Add (nome + "\t\t\t\t\t" + curso + "\t\t\t\t\t" + recorde);

		}

		foreach (string name in list) {

			textRanking.text += name + "\n";
		}
			
	}*/
}
