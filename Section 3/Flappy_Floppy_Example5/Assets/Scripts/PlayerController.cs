using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D rbody;
	//jumping back to the player we will need to grab the textscript and also the boolean of "gameBegan" we also will put back in the start method 
	 //and set the rigidbody type to Kinematic which will disable gravity on the object. we will set up a conditional in the update method to re-enable 
	 //gravity once the game begins 
	public TextBehaviour textScript; 
	//we will now create a new boolean to tell the text script when the player has died, this will also trigger the "Gameover" text
	public bool playerDeath = false; 

	void Start(){
		rbody.bodyType = RigidbodyType2D.Kinematic;
	}
		
	// Update is called once per frame
	void Update () {
		if (textScript.gameBegan == true){
			rbody.bodyType = RigidbodyType2D.Dynamic;
			PlayerInput ();
			PlayerMovement ();
		}

	}
		
	void PlayerInput(){
		if(Input.GetKey(KeyCode.Space)){
			rbody.AddForce (Vector2.up * 50);
		}
	}
		
	void PlayerMovement(){
		rbody.AddForce (Vector2.right * 20 * Time.deltaTime);
	}
		
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Danger"){
			playerDeath = true;
			Destroy (rbody);
		}
	}
}
