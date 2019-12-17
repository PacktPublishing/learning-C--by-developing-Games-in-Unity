using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//our DronePatrollingHealth script will now inherit from the DroneHealth parent class 
public class DronePatrollingHealth : DroneHealth {
	//since our patrolling drone health script inherits from Drone health we no longer need to set these variables since they are using the exact same 
	  //ones. You can observe this in the editor. 
//	[SerializeField]
//	protected Image enemyHealth;
//	[SerializeField]
//	protected GameObject explosion; 
//	[SerializeField]
//	protected Animation animClip; 

	// we will wind up eliminating a lot of the duplicate code that we had written for all of these methods 
	protected override void Start(){
		base.Start ();
//		animClip = GetComponent<Animation> ();
	}

	//in order to access and run the code in the parent class we must call base. followed by the method we want to access 
	protected override void Update(){
//		if(enemyHealth.fillAmount <= 0){
//			StartCoroutine("DeathAnim");
			base.Update();
//		}
	}

	protected override void OnCollisionEnter(Collision collision){
//		if (collision.gameObject.tag == "bullet"){
//			enemyHealth.fillAmount -= 0.09f;
			base.OnCollisionEnter(collision);
//		}
	}

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

	//you should now notice that there is no difference in our game. The drones still lose health and can explode 
}
