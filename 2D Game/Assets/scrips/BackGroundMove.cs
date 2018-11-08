using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {


	public CharacterMove Player;

	public bool isFollowing;



	public float xOffset;

	public float yOffset;


	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<CharacterMove>();

		isFollowing = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			xOffset = Player.GetComponent<Rigidbody2D>().velocity.x / 100;
			transform.position = new Vector3(transform.position.x + xOffset, transform.position.y , transform.position.z);
			
			//transform.position.x = Player.transform.position.x;
		}
		
	}
}