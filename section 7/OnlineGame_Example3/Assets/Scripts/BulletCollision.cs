using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "zombie"){
			var hit = collision.gameObject; 
			var zombieHit = hit.GetComponent<ZombieMovement>();
			if (zombieHit != null){
				Destroy (hit);
				print ("hit here");
			}
		}
		Destroy (this.gameObject);

	}
}
