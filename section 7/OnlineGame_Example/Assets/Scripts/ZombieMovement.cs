using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Transform playerPos = GameObject.FindGameObjectWithTag("Player").transform;
		transform.LookAt (playerPos);

		//put drag up to 5 so zombies move slower and do not flow so high up when they collide 
		//freeze all rotations but NOT the position
		GetComponent<Rigidbody> ().AddForce (transform.forward * 500f * Time.deltaTime);
	}
}
