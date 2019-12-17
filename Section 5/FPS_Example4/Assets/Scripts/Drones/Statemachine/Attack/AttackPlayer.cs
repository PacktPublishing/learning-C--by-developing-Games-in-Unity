using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//grab AI
using UnityEngine.AI;

public class AttackPlayer : MonoBehaviour {
	public float radius = 0f;
	//we will need to grab reference to the navagent and mesh agents to turn them off and on
	public Collider[] colliderSearch; 

	//set a bool to judge when the player is detected
	public bool playerDetected = false; 

	[SerializeField]
	private GameObject laser; 
	//timer so lasers arent instantiated a lot
	public int timer = 0;
	public Transform laserSpawn;

	
	// Update is called once per frame
	void Update () {
		timer += 1; 
		//well set the boolean to always be false unless the player is detected 
		playerDetected = false;
		colliderSearch = Physics.OverlapSphere (transform.position, radius); 

		foreach(Collider collider in colliderSearch){
			if (collider.tag == "player") {
				playerDetected = true; 
				if (playerDetected == true) {
					print ("Player Found");
					Transform playerPos = GameObject.Find ("Player").transform;
					transform.LookAt (playerPos.position);
					if (timer >= 15) {
						GameObject laserClone = Instantiate (laser, laserSpawn.transform.position, laserSpawn.transform.rotation); 
						laserClone.transform.rotation = Quaternion.Euler (100.81f, 57.34f, -56.90f);
						laserClone.GetComponent<Rigidbody> ().AddForce (laserSpawn.transform.forward * 1000);
						timer = 0;
						Destroy (laserClone, .5f);
					}
				}
			} 
		}

	}
}
