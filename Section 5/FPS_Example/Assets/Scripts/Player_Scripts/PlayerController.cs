using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private float speed = 6.0f;
	private float gravity = 20.0f;
	private float rotSpeed = 90.0f;
	private Vector3 moveDirection = Vector3.zero;

	// Update is called once per frame
	void Update () {
		PlayerMovement ();
	}

	void PlayerMovement(){
		//this time we will use the character controller for this script which will utilize some settings in Input settings. 
		  //In order to access input settings go to Edit -> Project Settings -> Input 
		  //From there you can change the buttons needed to move the player in the horizontal and vertical directions by assiging a button to the positive 
		  //and negative values 
		//we will also need to freeze the axises of the player object to keep it from falling over when colliding with objects 

		//We will need to grab a hold of the CharacterController script on this object and test if it is grounded or not. Since we are grounded this will allow
		  //us to move along the ground and still have physics inacted, if we apply force to the object it may just push the object around, if we just access
		  //the Horizontal and Vertical indexes of the object then this will cause all applied physics to be ignored, which is why using the CharacterController
		  //component is important here 

		transform.Rotate(0, Input.GetAxis("Horizontal")* rotSpeed * Time.deltaTime, 0);

		CharacterController controller = gameObject.GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = Vector3.forward * Input.GetAxis("Vertical");
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}
