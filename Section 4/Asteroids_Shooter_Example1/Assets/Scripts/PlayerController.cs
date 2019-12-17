using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//after we set up the scene lets be sure to set the gravity scale to zero on the rigidbody but leave it as dynamic 

	//here we will use a Private variable and grab the rigidbody using code.
	 //we will initialze the rbody variable in the Start method by setting it to grab the rigidbody
	//It is considered best practice to "hide data" using private variables and grabbing reference to the component through code 
	private Rigidbody2D rbody; 

	//we will use serialize field here on a private variable which will keep the variable private but allow us to access it in the editor
	  //this is also considered best practice 
	[SerializeField]
	private ParticleSystem flares; 

	// Use this for initialization
	void Start () {
		rbody = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//set bools equal to if the key is being pressed or not 
		bool goForward = Input.GetKey(KeyCode.W); 
		bool turnLeft = Input.GetKey(KeyCode.A);
		bool turnRight = Input.GetKey(KeyCode.D); 

		//adjust angular drag in order to control the ship better, because there is no gravity the ship will continue to float forward
		if (goForward) {
			rbody.AddForce (this.transform.up * -2);

			//when making particle system be sure to adjust the 
			  //Box Y - 5
			  // Color over lifetime 
			  //Play on awake - off
			  //emission rate over time - 20, rate over distance - 3
			flares.Emit (1);
		} 

		if (turnLeft) {
				rbody.AddTorque(500);
		} 

		if (turnRight) {
				rbody.AddTorque (-500);
		} 

	}
}
