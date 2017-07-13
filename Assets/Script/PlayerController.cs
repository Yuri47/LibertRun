using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject player;
	public float forca;
	private Rigidbody2D myBody;
	public bool grounded = false;


	 

	public int tempScore;

	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();


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

		}

	}


 

















}
