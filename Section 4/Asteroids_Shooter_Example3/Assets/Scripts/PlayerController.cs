using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rbody; 

	[SerializeField]
	private ParticleSystem flares; 

	[SerializeField]
	private GameObject laser; 

	// Use this for initialization
	void Start () {
		rbody = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		FireLaser ();

		bool goForward = Input.GetKey(KeyCode.W); 
		bool turnLeft = Input.GetKey(KeyCode.A);
		bool turnRight = Input.GetKey(KeyCode.D); 

		if (goForward) {
			rbody.AddForce (this.transform.up * -2);
			flares.Emit (1);
		} 

		if (turnLeft) {
				rbody.AddTorque(500);
		} 

		if (turnRight) {
				rbody.AddTorque (-500);
		} 

	}

	void FireLaser(){
		//we must use getkeydown to avoid instantiating more than 1 prefab at a time
		if (Input.GetKeyDown(KeyCode.Space)){
			//now that we have made the laser prefab it is time to instatiate at our Spawn Area position and add a force to it to propel it forward
			Transform spawnArea = gameObject.transform.GetChild(1).transform;
			GameObject laserClone = Instantiate (laser, spawnArea.position, spawnArea.rotation);

			laserClone.GetComponent<Rigidbody2D> ().AddForce (this.transform.up * -10000);

			//we will specify a time to destroy the clone, this will save on our memory nad performance by destroying each clone that is produced 
			Destroy (laserClone, 2.0f);
		}

	}
}
