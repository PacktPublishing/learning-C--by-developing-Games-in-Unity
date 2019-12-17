using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {
	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private Transform spawnArea; 
    //add a timer to control how quickly bullets will spawn 
	public int timer = 0; 
	
	// Update is called once per frame
	void Update () {
		timer += 1;
		SpawnBullet ();
	}

	void SpawnBullet(){
		if (Input.GetMouseButtonDown(0) && timer >= 20){
			GameObject bulletClone = Instantiate (bullet, spawnArea.position, spawnArea.rotation);
			//add force according to the position of the spawn area to get the bullet to shoot perfectly straight in relation to where the spawn area is pointing
			bulletClone.GetComponent<Rigidbody> ().AddForce (spawnArea.transform.up * 800);
			timer = 0;
			Destroy (bulletClone, .5f);
		}

	}
}
