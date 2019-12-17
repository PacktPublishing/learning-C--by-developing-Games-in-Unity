using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {
	[SerializeField]
	private GameObject explosion;  

	void OnCollisionEnter2D(Collision2D collision){
		//Grab reference to the updatescore from the game manager 
		TextUpdate updateScore = GameObject.Find ("GameManager").GetComponent<TextUpdate>();

		//we will need to grab reference to the game manager for the audio soruce because the audio source will not play once the asteroid is destroyed 
		//we will need the audio source attached to a gameobject that will remain in the scene 
		AudioSource explosionSound = GameObject.Find ("GameManager").GetComponent<AudioSource> ();

		if (collision.gameObject.tag == "Laser" && this.gameObject.tag == "Asteroid") {
			//add one to the scorenum
			updateScore.scoreNum += 1; 
			//play explosion sound
			explosionSound.Play();
			Destroy (gameObject);
			GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (explosionClone, 1f);
		} 

		//add this to the script to destroy the laser against the barrier 
		if (this.gameObject.tag == "Laser" && collision.gameObject.tag == "Asteroid" || collision.gameObject.tag == "Barrier") {
			Destroy (gameObject);
		}
	}
}
