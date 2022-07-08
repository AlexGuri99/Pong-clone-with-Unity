using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
	public int score1 = 0;
	public int score2 = 0;
	public int maxScore = 5;

	public GameObject scoreTextP1;
	public GameObject scoreTextP2;
	
	// Update is called once per frame
	void Update () 
	{
		newUpdate();
		if (score1 == maxScore || score2 == maxScore) 
		{
			SceneManager.LoadScene("GameOver");
			this.score1 = 0;
			this.score2 = 0;
		}
	}
	public void newUpdate()
	{
		Text scoreP1 = this.scoreTextP1.GetComponent<Text>();
		scoreP1.text = score1.ToString();

		Text scoreP2 = this.scoreTextP2.GetComponent<Text>();
		scoreP2.text = score2.ToString();
	}
}
