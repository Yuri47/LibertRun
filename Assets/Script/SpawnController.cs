using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public GameObject enemiePrefab;
	public float rateSpawn;
	public float currentTime;
	private int posicao;
	private float y;
	private float x;

	public float posicYPlayer;
	public float tempoDestruir;
	public float distanciaEntreSpawn;

	public float score;

	// Use this for initialization
	void Start () {
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		 
			currentTime += Time.deltaTime;
			score += Time.deltaTime;

			if (currentTime >= rateSpawn) {
				currentTime = 0;
			//	y += distanciaEntreSpawn;
				x = Random.Range (13.93f, 19.09f);

			GameObject tempPrefab = Instantiate (enemiePrefab) as GameObject;
			tempPrefab.transform.position = new Vector2 (x, -1.21f);
				Destroy (tempPrefab.gameObject, tempoDestruir);
			}
		 
	}
}
