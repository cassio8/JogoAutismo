using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class InsertBank : MonoBehaviour {
	/*
	private string source;
	private MySqlConnection conexao;
	//public Text textRanking;
	private int i;
	private string t;
	//private List<string> list = new List<string>();
	public InputField name;
	public InputField curso;
	string nameString, cursoString;
	private int highscoreTable;
	private BoinaScore bs = new BoinaScore ();

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		
	}

	void conectarBanco(string _source)  {

		conexao = new MySqlConnection(_source);
		conexao.Open();
	}

	void listar(MySqlConnection _conexao)  {

		MySqlCommand comandoInserir = _conexao.CreateCommand();
		comandoInserir.CommandText = "INSERT INTO ranking VALUES ('"+getName()+"', '"+getCurso()+"', '"+getHighScore()+"')";
	    MySqlDataReader dados = comandoInserir.ExecuteReader();


	}

	public void clicouJogarUserScene()  {
		
		nameString =  name.text;
		cursoString = curso.text;

		Debug.Log (nameString + " " + cursoString);

		SceneManager.LoadScene ("GameBoina");

		bs.recebeu (nameString, cursoString);

	}

	public void playerGameOver(int highscore, string name, string curso)  {
		Debug.Log ("Entrou");
		highscoreTable = highscore;

		nameString =  name;
		cursoString = curso;

		Debug.Log (bs.getName() + " " + bs.getCurso());


		source = "server = localhost;" +  //se por na web alterar aqui IP
				 "Database = rankingboina;" +
				 "User ID = root;" +
				 "Pooling = false;"  +
				 "Password =";

		conectarBanco(source);
		listar (conexao);
	}
	
	}*/
}
