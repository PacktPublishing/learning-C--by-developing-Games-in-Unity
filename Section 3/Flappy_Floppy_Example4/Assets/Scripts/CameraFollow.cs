using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	//for this we will only need the update method 
	//we will take the tranform of the player object using a public variable 
	//then we will set the camera to follow the player as they move across the screen 
	public Transform playerPos; 

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position = new Vector3 (playerPos.position.x + 5, playerPos.position.y, this.gameObject.transform.position.z);
	}
}
