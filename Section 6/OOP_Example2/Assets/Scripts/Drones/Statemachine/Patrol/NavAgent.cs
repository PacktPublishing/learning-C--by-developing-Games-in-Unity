using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add the AI namespace 
using UnityEngine.AI;
public class NavAgent : MonoBehaviour {
	[SerializeField]
	private Transform[] endPoint; 
	private int destPoint = 0;
	NavMeshAgent agent; 
	// Use this for initialization

	//when maing navigation for our drones we will first need to make a NavMesh by going to Window -> Navigation and applying
	  //the needed settings. After we will add the NavMeshAgent to our drones and then begin scripting.
	void Start () {
		agent = GetComponent<NavMeshAgent> ();

		//disabling auto-baking allows for continuous movement between points
		agent.autoBraking = false;

		GoToNextPoint ();
	}

	void GoToNextPoint(){
		//returns if no points have been set up
		if (endPoint.Length == 0) {
			return;
		}

		agent.destination = endPoint [destPoint].position;

		//add one to the destpoint integer to cycle through the positions 
		//cycle back to teh start if neccessary 
		destPoint = (destPoint + 1) % endPoint.Length;
	}
	
	// Update is called once per frame
	void Update () {
		//choose the next destination point when the agent gets close to the current one
		if (!agent.pathPending && agent.remainingDistance < 0.5f) {
			GoToNextPoint ();
		}
	}
		
}
