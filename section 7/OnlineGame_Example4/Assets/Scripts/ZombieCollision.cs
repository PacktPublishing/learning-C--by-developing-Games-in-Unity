using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player"){
			var attack = collision.gameObject;
			var playerHit = attack.GetComponent<Health> ();

			if (playerHit != null){
				 playerHit.TakeDamage (10);
			}
		} 
	}
}
