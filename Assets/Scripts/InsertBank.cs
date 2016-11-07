using UnityEngine;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class InsertBank : MonoBehaviour  {
	
	private string source;
	private MySqlConnection conexao;


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

	void conectarBanco(string _source)  {

		conexao = new MySqlConnection(_source);
		conexao.Open();
	}
		
	void listar(MySqlConnection _conexao)  {

		EstadosBanco.setEstado (7);

		string nome, tempoResposta;
		int erros, omissoes;

		nome = ControlBank.getNome ();
		erros = ControlBank.getErros ();
		omissoes = ControlBank.getOmissoes ();
		tempoResposta = ControlBank.getTempoResposta ();

		//inserir tabela paciente
		MySqlCommand comandoInserir = _conexao.CreateCommand();
		comandoInserir.CommandText = "INSERT INTO paciente (cod_paciente, nome) VALUES ('', '"+ nome +"')";
	    MySqlDataReader inserirPaciente = comandoInserir.ExecuteReader();
		//comandoInserir.LastInsertedId;

		inserirPaciente.Close ();

		//inserir tabela resultado
		MySqlCommand comandoInserirResultado = _conexao.CreateCommand();
		comandoInserirResultado.CommandText = "INSERT INTO resultado (cod_resultado, cod_paciente, erros, omissoes, tempo_resposta) VALUES ('','"+comandoInserir.LastInsertedId+"', '"+ erros +"', '"+ omissoes +"', '"+ tempoResposta +"')";
		MySqlDataReader inserirResultado = comandoInserirResultado.ExecuteReader();

		Debug.Log ("Inserido no banco com sucesso!");
	}
		

}
