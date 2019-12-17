using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rbody; 

	public List<GameObject> lives; 

	[SerializeField]
	private ParticleSystem flares; 

	[SerializeField]
	private GameObject laser; 

	[SerializeField]
	private GameObject explosion; 

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
		//if the total number of objects in the list are 0 then destroy the player object and instantiate the explosion for a little bit 
		if(lives.Count == 0){
			Destroy (this.gameObject);
			GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (explosionClone, 2f);
		}
	}

	void FireLaser(){
		if (Input.GetKeyDown(KeyCode.Space)){
			Transform spawnArea = gameObject.transform.GetChild(1).transform;
			GameObject laserClone = Instantiate (laser, spawnArea.position, spawnArea.rotation);

			laserClone.GetComponent<Rigidbody2D> ().AddForce (this.transform.up * -10000);

			Destroy (laserClone, 2.0f);
		}

	}

	//use our List of player lives and once the player collides with an asteroid, they will lose a life by having the gameobject destroyed then removed from
	  //the list 
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Asteroid"){
			Destroy (lives [0].gameObject);
			lives.Remove (lives [0]);
		}
	}
}
