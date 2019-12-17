using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D rbody;
		
	// Update is called once per frame
	void Update () {
		print("its working!");
		PlayerInput ();
		PlayerMovement ();
	}
		
	void PlayerInput(){
		if(Input.GetKey(KeyCode.Space)){
			rbody.AddForce (Vector2.up * 50);
		}
	}
		
	void PlayerMovement(){
		rbody.AddForce (Vector2.right * 20 * Time.deltaTime);
	}

	//Now that we have added colliders to our mountains and the barriers, we now want it so that when our player collides with one of these objects, 
	  //they will be unable to play the game, resulting in a version of player death. We will want the player to die if they hit the top, bottom, left, 
	  //or mountain barriers, however if they hit barrier on the far right they will win the game which we will get to later on. 
	//In order to create player death we will use another method called OnCollision2D. We will also create tags to for the objects that can kill our player
	  //once the player collides with one of these dangerous colliders we will destroy the rigidbody on the player.
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Danger"){
			Destroy (rbody);
		}
	}
}
