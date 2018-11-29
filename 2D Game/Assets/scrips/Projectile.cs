using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float Speed;
	public float TimeOut;
	public Rigidbody2D enemy;
	public GameObject gaben;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;
	public GameObject DeathParticle;
	public int PointsForKill;
	public int deathtime;
	// Use this for initialization
	void Start () {
		gaben = GameObject.Find("gaben");

		EnemyDeath = Resources.Load("Prefab/p1") as GameObject;
		ProjectileParticle = Resources.Load("Prefab/p2") as GameObject;
		if(gaben.transform.localScale.x < 0)
			Speed = Speed * -1;
		
			//speed = speed * Mathf.Sign(gaben.transform.localScle.x);

			//GetComponent<Rigidbody2D>().velocity = new Vector2(speed + ()
		
	
		Destroy(gameObject,TimeOut);
	
	}


	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
		//GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x, Speed);
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			//Instantiate (DeathParticle, enemy.transform.position, enemy.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}

		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
