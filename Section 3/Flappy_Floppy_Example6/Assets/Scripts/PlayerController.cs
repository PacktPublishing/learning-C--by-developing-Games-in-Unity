using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D rbody;
	public TextBehaviour textScript; 
	//we will add one more bool to track when the player has crossed the finish line
	public bool playerDeath = false, playerWin = false; 
	//grab reference to the button handler script 
	public ButtonHandler buttonAction; 

	void Start(){
		rbody.bodyType = RigidbodyType2D.Kinematic;
	}
		
	// Update is called once per frame
	void Update () {
		if (buttonAction.startGame == true){
			rbody.bodyType = RigidbodyType2D.Dynamic;
			PlayerInput ();
			PlayerMovement ();
		}
		//if the player wins stop the movement 
		if (playerWin == true){
			rbody.bodyType = RigidbodyType2D.Kinematic;
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
			//add this else if statement for if the player collides with the end wall to win
		} else if (collision.gameObject.tag == "Victory"){
			playerWin = true;
		}
	}
}
