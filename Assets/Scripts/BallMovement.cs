using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour 
{
	public float speed=200;
	public float addedSpeed = 50;
	public float maxSpeed = 1000;
	public int hitCounter = 0;

	void Start () 
	{
		StartCoroutine (this.startBall ());
	}

	public IEnumerator startBall()
	{
		this.hitCounter = 0;
		yield return new WaitForSeconds(2);
		this.moveBall(new Vector2 (-1, 0));
	}

	public void moveBall(Vector2 direction)
	{
		direction = direction.normalized;
		float velo = this.speed + this.addedSpeed * this.hitCounter;
		Rigidbody2D rg = this.gameObject.GetComponent<Rigidbody2D>();
		rg.velocity = velo * direction;
	}

	public void hitCounterIncrement()
	{
		if (this.speed <= this.maxSpeed)
			this.hitCounter++;
	}
}
