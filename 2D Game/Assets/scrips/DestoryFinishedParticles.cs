using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryFinishedParticles : MonoBehaviour {


	private ParticleSystem thisParticleSystem;

	// Use this for initialization
	void Start () {
		thisParticleSystem = GetComponent<ParticleSystem>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(thisParticleSystem.isPlaying)
		{
			return;
		}
		else
		{
			Destroy (gameObject);
		}
	}


	void OnBecomeInvisible (){
		Destroy (gameObject);
	}
}
