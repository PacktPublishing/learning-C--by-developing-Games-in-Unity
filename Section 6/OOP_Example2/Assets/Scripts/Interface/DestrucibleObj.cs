using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrucibleObj : MonoBehaviour, IDestructable {

	[SerializeField]
	protected GameObject explodeObj; 

	private int hitCounter = 0;

	public void DestructionOccur(){
		//count how many times is hit, at 3 hits destroy the object and instantiate the explosion 
		hitCounter += 1;
		if (hitCounter >= 3){
			Instantiate(explodeObj, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		}

	}
}
