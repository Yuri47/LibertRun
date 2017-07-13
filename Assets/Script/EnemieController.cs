using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour {

	public GameObject enemie;
	private Rigidbody2D enemieBody;
	public float velocidade;

	// Use this for initialization
	void Start () {

		enemieBody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

		enemieBody.velocity = new Vector2 (velocidade, 0); 
		
	}
}
