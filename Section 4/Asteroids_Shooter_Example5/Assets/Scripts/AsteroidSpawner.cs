using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {
	public GameObject[] asteroidSpawns; 
	float maxTime = 5;
	float minTime = 2;

	private float time; 
	private float spawnTime; 

	void Start() {
		SetRandomTime (); 
		time = minTime; 
	}

	// Update is called once per frame
	void FixedUpdate () {
		time += Time.deltaTime;
		while (time > spawnTime) {
			time = 0;
			int i = Random.Range (0, asteroidSpawns.Length);
			GameObject asterClone = Instantiate (asteroidSpawns[i]);
			asterClone.transform.position = Random.insideUnitCircle * 5; 
		}

	}
		
	void GenerateAsters(){
			time = 0;
			int i = Random.Range (0, asteroidSpawns.Length);
			GameObject asterClone = Instantiate (asteroidSpawns[i]);
			asterClone.transform.position = Random.insideUnitCircle * 5; 
	}

	void SetRandomTime(){
		spawnTime = Random.Range (minTime, maxTime);
	}
		

}
