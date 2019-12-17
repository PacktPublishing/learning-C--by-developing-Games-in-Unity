using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DronePatrollingHealth : DroneHealth, IDestructable {

	protected override void Start(){
		base.Start ();
	}
		
	protected override void Update(){

			base.Update();
	}

//	protected override void OnCollisionEnter(Collision collision){
////		if (collision.gameObject.tag == "bullet"){
////			enemyHealth.fillAmount -= 0.09f;
//			base.OnCollisionEnter(collision);
////		}
//	}

	IEnumerator DeathAnim(){
		animClip.Play ("Drone_Death");
		yield return new WaitForSeconds (animClip.clip.length);
		GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
		Destroy (explosionClone, 0.5f);
		Destroy (gameObject, 0.5f);
	}

	public override void DroneDeath(){
		base.DroneDeath ();
	}
		
	//becuase this is a child class we must use override as before 
	public override void DestructionOccur(){
		//call the same method on the parent class 
		base.DestructionOccur ();
	}

	//all of our health scripts should be working the same as before, only now we are using an interface 
}
