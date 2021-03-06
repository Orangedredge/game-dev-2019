﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;

	public Rigidbody2D gaben;

	public GameObject PC2;

	//particles

	public GameObject DeathParticle;

	public GameObject RespawnParticle;

	//Respawn Delay

	public float RespawnDelay;

	//point penalty on Death

	public int PointPenaltyOnDeath;
	//store Gravity Value
	private float GravityStore;


//Use this for initialization

	void Start () {
		gaben = GameObject.Find("gaben").GetComponent<Rigidbody2D>();
		//gaben = FindObjectOfType<Rigidbody2D>();
		PC2 = GameObject.Find("gaben");
	}


	public void RespawnPlayer(){
		StartCoroutine ("RespawnPCo");
	}


	public IEnumerator RespawnPCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, gaben.transform.position, gaben.transform.rotation);
		
		//hide pc
		//PC.ennabled = false;
		PC2.SetActive(false);
		gaben.GetComponent<Renderer>().enabled = false;
		//Gravity Reset
		GravityStore = gaben.GetComponent<Rigidbody2D>().gravityScale;
		gaben.GetComponent<Rigidbody2D>().gravityScale = 0f;
		gaben.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// point penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug message
		Debug.Log ("lord gaben has Respwned ");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		gaben.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//match gabens transform postion
		gaben.transform.position = CurrentCheckPoint.transform.position;
		//show gaben
		//gaben.enabled = true;

		PC2.SetActive(true);
		gaben.GetComponent<Renderer> ().enabled = true;
		//Spawn gaben
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
		
		
		
		}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
