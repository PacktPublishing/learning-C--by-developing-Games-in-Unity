using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.GetComponent<IDestructable>() != null){
			//Call the DestructionOccur method on a component that implements the IDestrucable interface
			collision.gameObject.GetComponent<IDestructable>().DestructionOccur();
		}
	}
}
