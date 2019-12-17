using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {
	[SerializeField]
	private GameObject explosion; 
	//we will use two conditionals to destroy both the laser and the asteroid when they collide
	//WE will instantiate an explosion effect once the asteroid is destroyed 
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Laser" && this.gameObject.tag == "Asteroid") {
			Destroy (gameObject);
			GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (explosionClone, 1f);
		} 

		if (this.gameObject.tag == "Laser" && collision.gameObject.tag == "Asteroid") {
			Destroy (gameObject);
		}
	}
}
