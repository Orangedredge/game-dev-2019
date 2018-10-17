using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float Speed;

	public Rigidbody2D gaben;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;
	public int deathtime;
	// Use this for initialization
	void Start () {
		if(gaben.transform.localScale.x < 0){
			Speed = -Speed;
		
			//speed = speed * Mathf.Sign(gaben.transform.localScle.x);

			//GetComponent<Rigidbody2D>().velocity = new Vector2(speed + ()
	
		}
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}

		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		;
	}
}
