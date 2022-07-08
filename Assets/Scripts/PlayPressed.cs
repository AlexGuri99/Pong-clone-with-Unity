﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayPressed : MonoBehaviour {
	public void playPressed()
	{
		SceneManager.LoadScene("inGame");
	}
	public void exitPressed()
	{
		Application.Quit();
	}

}
