using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

	public float speed = 300;
	public Rigidbody2D rb;
	public Score sc;
	public AudioSource playerHit;
	//public BallCollision ball;

	// Use this for initialization
	void Start()
	{
		Launch();
	}
	// Update is called once per frame
	void Update()
	{
		
	}

	public void Launch()
	{
		float x = Random.Range(0, 2) == 0 ? -1 : 1;
		float y = Random.Range(0, 2) == 0 ? -1 : 1;
		rb.velocity = new Vector2(speed * x, speed * y);
	}

	public void throwAgain(bool who)
	{
		float y = Random.Range(0, 2) == 0 ? -1 : 1;

		if (who == true) 
		{
			this.gameObject.transform.localPosition = new Vector3(-50, 0, 0);
			rb.velocity = new Vector2(speed * (-1), speed * y);
		} 
		else 
		{
			this.gameObject.transform.localPosition = new Vector3(50, 0, 0);
			rb.velocity = new Vector2(speed , speed * y);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "WallLeft") 
		{
			sc.score2++;
			this.throwAgain (true);
		} 
		else if (col.gameObject.name == "WallRight") 
		{
			sc.score1++;
			this.throwAgain (false);
		} 
		else if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2") 
		{
			this.playerHit.Play();
		}
	}
}
