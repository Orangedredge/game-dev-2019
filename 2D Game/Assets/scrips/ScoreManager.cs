using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
public static int Score;
Text ScoreText;
public static int ammo;
Text ammotext;
	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();
		Score = -1;
		ammotext = GetComponent<Text>();
		ammo = -1;
	}
	
	// Update is called once per frame
	void Update () {
		ammotext.text = " " + Score;
		if (score < 0 ){
			Score = 0
		}

		ScoreText.text = " " + Score;
		if (Score < 0)
		{
			Score = 0;
			
		}

		

	}

	public static void AddPoints (int PointsToAdd)
	{
		Score += PointsToAdd;
	}
}
