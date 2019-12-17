using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class ZombieSpawner : NetworkBehaviour {
	public int numberOfZombies; 
	public GameObject zombie; 
	// Update is called once per frame
	public override void OnStartServer () {
		SpawnZombies ();

	}

	void Update(){
		int zombiesInScene = GameObject.FindGameObjectsWithTag ("zombie").Length;

		if (zombiesInScene == 0){
			SpawnZombies ();
		}
	}

	void SpawnZombies (){
		for (int i = 0; i < numberOfZombies; i++) {
			var spawnPos = new Vector3 (Random.Range (-8.0f, 8.0f), 0.0f, Random.Range (-8.0f, 8.0f));

			var spawnRot = Quaternion.Euler (0.0f, Random.Range (0, 180), 0.0f);
			var zombieClone = (GameObject)Instantiate (zombie, spawnPos, spawnRot);
			NetworkServer.Spawn (zombieClone);
		}
	}
}
