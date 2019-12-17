using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour {
	private Transform playerTrans;
	private float smoothTime = 2.5f;
	private Vector3 velocity = Vector3.zero;

	//A smooth damp will gradually change a vector towards a desired target over time
	  //the vector is smoothed by a spring-damper like function which will never overshoot the target

	// Use this for initialization
	void Start () {
		playerTrans = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = new Vector3 (playerTrans.position.x, playerTrans.position.y, transform.position.z);
		transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
	}
}
