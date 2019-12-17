using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DroneStateMachine : MonoBehaviour {

	//first create an enumerator which will house our states 
	enum States
	{
		PATROL,
		ATTACK
	};
	States currentState = States.PATROL;

	private NavAgent dronePatrolling; 
	private AttackPlayer droneAttacking; 
	NavMeshAgent thisNavMesh;
	// Use this for initialization
	void Start () {
		dronePatrolling = GetComponent<NavAgent> ();
		droneAttacking = GetComponent<AttackPlayer> ();
		thisNavMesh = GetComponent<NavMeshAgent> ();
		ChangeState (States.PATROL);
	}
	
	// Update is called once per frame
	void Update () {
		if (droneAttacking.playerDetected == true) {
			ChangeState (States.ATTACK);
		} 

		if (droneAttacking.playerDetected == false) {
			ChangeState (States.PATROL);
		} 
	}

	//now we will create a method which will determine when to change our state. It will take a parameter of newState
	void ChangeState(States stateVal){
		//checks to see if we are trying to change from our current state to a new state 
		if (currentState == stateVal){
			//return if nothing happens
			return;
		}

		//we will use a case/switch statement which acts like a conditional but takes in the possible values of each 
		  //state in this case and will run code depending on the value
		switch (stateVal) 
		{
		case States.PATROL:
			{
				dronePatrolling.enabled = true;
				thisNavMesh.enabled = true;
				break;
			}
		case States.ATTACK:
			{
				dronePatrolling.enabled = false;
				thisNavMesh.enabled = false;
				break;
			}
			//default case at the end in case we get a junk value passed in
		default:
			{
				return;
			}
		}

		currentState = stateVal;
	}
}
