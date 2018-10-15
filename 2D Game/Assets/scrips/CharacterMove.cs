using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {


	// player movement variables
public float moveSpeed;
public float jumpheight;


// player grounded variables
public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;
private bool grounded, doublejump = true;


	
//Non-slide PLAYER
private float moveVelocity;

	// Use this for initialization
	void Start () {
		
	}



	
	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}


	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space)&& grounded){
			Jump();
			doublejump = true;
		}



		//this code makes the character move from side to side using the A and D keys
		if(Input.GetKey (KeyCode.D)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
		}
		if(Input.GetKey (KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>(). velocity.y);

		if (GetComponent<Rigidbody2D>().velocity.x > 0){
			transform.localScale = new Vector3(0.1f,0.1f,1f);
		}
		else if (GetComponent<Rigidbody2D>().velocity.x < 0){

			transform.localScale = new Vector3(-0.1f,0.1f,1f);
		}

		//to double jump
		if (Input.GetKeyDown (KeyCode.Space) && doublejump ==  true && !grounded){
			Jump();
			doublejump = false;
			
		}
		//Non-slide PLAYER
		moveVelocity = 0f;

	}
	
	public void Jump(){
	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
	}

}