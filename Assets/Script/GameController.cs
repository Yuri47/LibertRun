using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject painel;
	public float score;
	public Text textScore;
	private float tempScore;

	private float aux;

	// Use this for initialization
	void Start () {
		painel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		tempScore = aux + score * 1.2f;
		textScore.text = tempScore.ToString ("n2");
		
	}

	public void Pause() {
		Time.timeScale = 0;
		painel.SetActive(true);
	}
	public void UnPause() {
		Time.timeScale = 1;
	}
	public void Restart() {
		SceneManager.LoadScene ("Game");
		Time.timeScale = 1;
	}

	public void pegouGold(float f) {

		aux += 100f;
		 
		Debug.Log (tempScore);
	
	}

}
