using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

	public int speed = 300;
	Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float move = Input.GetAxis ("Vertical");
		myRigidbody.velocity = new Vector2 (0, move) * speed;
	}
}