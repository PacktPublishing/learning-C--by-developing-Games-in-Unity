using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//a public variable can be accessed in the editor and the object placed in the open socket which will grant access to the specific 
	  //component 
	//Rigidbodies control the physics of an object, in this case this will cause our player to fall when the game starts 
	public Rigidbody2D rbody;
	// Use this for initialization
//	void Start () {
//		
//	}
		
	//we will create two methods one for player input and one to move the player forward and call them here
	// Update is called once per frame
	void Update () {
		print("its working!");
		PlayerInput ();
		PlayerMovement ();
	}

	//We will use a KeyCode to take notice as to when the player has hit the space bar. we will take the rigidbody of the object and then
	  //apply a force to it in the up direction 
	void PlayerInput(){
		if(Input.GetKey(KeyCode.Space)){
			rbody.AddForce (Vector2.up * 50);
		}
	}

	//like flappy bird we will move our player forward the entire time by apply a force to the rigidboy to the right 
	void PlayerMovement(){
		rbody.AddForce (Vector2.right * 20 * Time.deltaTime);
	}
}
