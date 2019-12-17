using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {
	public Transform[] spawnPoints;
	public GameObject zombie; 
	public int timer = 0; 
	// Update is called once per frame
	void Update () {
		timer += 1; 
		while (GameObject.FindGameObjectsWithTag("zombie").Length < 6 && timer >= 20){
			int randNum = Random.Range (0, spawnPoints.Length);
			GameObject zombieClone = Instantiate (zombie, spawnPoints [randNum].position, spawnPoints [randNum].rotation);
			timer = 0;
		}
	}
}
