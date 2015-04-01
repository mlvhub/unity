﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public BoardManager boardScript;

	[HideInInspector]
	public bool playersTurn = true;

	private int level = 3;

	public int playerFoodPoints;

	// Use this for initialization
	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		DontDestroyOnLoad(gameObject);
		boardScript = GetComponent<BoardManager>();
		InitGame();
	}

	void InitGame()
	{
		boardScript.SetupScene(level);
	}

	public void GameOver() {
		enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
