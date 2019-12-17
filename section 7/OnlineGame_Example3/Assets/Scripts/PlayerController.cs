using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add UnityEngine.Networking
using UnityEngine.Networking;

//inherit from network behaviour 
public class PlayerController : NetworkBehaviour {
	public GameObject bullet;

	public Transform spawnArea;
	// Update is called once per frame

	//here we can access the verticies of the axis without having to use a character controller
	  //our scene for this game will not have any walls, or other objects that we want to stop the collisions with
	  //completely 
	//** show where to find the verticies under edit -> project settings -> Input **

	void Update () {
		//this will check and run the local player processes first 
		//after adding this check we will add the component network trasform to the player prefab 
		  //the networktransform will synchronize the gameobjects transform across the network 
		//this allows for the local player to ONLY move the local player gameobject 
		//BE SURE THE NETWORK TRANSFORM IS SET TO SYNC TRANSFORM 
		if (!isLocalPlayer){
			return; 
		}

//		bool mousePressed = Input.GetMouseButtonDown (0);
		if (Input.GetKeyDown(KeyCode.Mouse0)){
			CmdShoot ();
		}


		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 300.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 20.0f;

		transform.Rotate (0, x, 0);
		transform.Translate (0, 0, z);
	}

	//the command attribute indicates that the following function will be called by the client, but will run on the server
	//the command allows for any arguments in the funciton to be passed to the server 
	//commands can only be sent from the local player object 
	//when making a command the function must be renamed to start with Cmd 
	[Command]
	void CmdShoot(){
//		bool mousePressed = Input.GetMouseButtonDown(0);
//		if(mousePressed){
			GameObject bulletClone = (GameObject)Instantiate (bullet, spawnArea.position, spawnArea.rotation);
//			bulletClone.GetComponent<Rigidbody> ().AddForce (spawnArea.transform.forward * 50.0f);
			bulletClone.GetComponent<Rigidbody> ().velocity = bulletClone.transform.forward * 6;

			//spawn the bullet on all clients connected to the server 
			//the bullet will now be handled by the spawning system of the network manager 
			NetworkServer.Spawn(bulletClone);
			Destroy (bulletClone, 2.0f);
//		}
	}

	//We cannot really tell the two players apart from each other so we will create a method to distinguish them
	//we will use the OnStartLocalPlayer function here to change the player's color to blue instead of green
	public override void OnStartLocalPlayer(){
		GetComponent<MeshRenderer> ().material.color = Color.blue; 
	}
}
	