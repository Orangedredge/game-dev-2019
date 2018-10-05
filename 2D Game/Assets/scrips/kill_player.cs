using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_player : MonoBehaviour {

	public LevelManager LevelManager;

	



	void Start (){
		LevelManager = FindObjectOfType <LevelManager>();
	}


void OnTriggerEnter2D(Collider2D other){
	if(other.name == "gaben"){
		LevelManager.RespawnPlayer();
	}
}



	// Update is called once per frame
	void Update () {
		
	}
}
