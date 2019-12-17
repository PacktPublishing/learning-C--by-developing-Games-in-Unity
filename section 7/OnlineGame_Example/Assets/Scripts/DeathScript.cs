using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if (this.gameObject.tag == "Player" && collision.gameObject.tag == "zombie"){
			GameObject playerObj = GameObject.Find ("Player");
			Destroy (playerObj);
		} else if (this.gameObject.tag == "zombie" && collision.gameObject.tag == "bullet"){
			GameObject zombieObj = GameObject.FindGameObjectWithTag("zombie");
			Destroy (zombieObj);
		}
	}
}
