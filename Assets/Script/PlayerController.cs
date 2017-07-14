using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject player;
	public float forca;
	private Rigidbody2D myBody;
	public bool grounded = false;
	public GameObject gameControl;
	private GameController gameController;


	 

	public int tempScore;

	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
		gameController = gameControl.GetComponent<GameController> ();
		 
		//player = FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;

	}
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("up") || Input.GetKeyDown ("w")) { //GetKey executa enquanto estiver apertando o botão



			if (grounded) {
				myBody.velocity = new Vector2 (0f, forca);
			}
			Debug.Log("apertou cima");
		}

		var absY = Mathf.Abs (myBody.velocity.y);

		if (absY < .2f) {
			grounded = true;
		} else {
			grounded = false;
		}



	}

	void OnCollisionEnter2D(Collision2D coll) { //
		if (coll.gameObject.tag == "enemie") {
			 
			Debug.Log ("morreu fdp");
			 
			gameController.Pause ();
		 
		}

		if (coll.gameObject.tag == "gold") {

			//Debug.Log ("pegou gold");
			Destroy (coll.gameObject, 0);

			gameController.pegouGold (10f);

		}



	}


 

















}
