using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//implement the interface 
public class DroneHealth : MonoBehaviour, IDestructable {

	[SerializeField]
	protected Image enemyHealth;
	[SerializeField]
	protected GameObject explosion; 
	[SerializeField]
	protected Animation animClip; 

	protected virtual void Start(){
		animClip = GetComponent<Animation> ();
	}
		
	protected virtual void Update(){

	}

	//we now no longer need this oncollision method 
//	protected virtual void OnCollisionEnter(Collision collision){
////		if (collision.gameObject.tag == "bullet"){
////		}
//	}
		
	IEnumerator DeathAnim(){
		animClip.Play ("Drone_Death");
		yield return new WaitForSeconds (animClip.clip.length);
		GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
		Destroy (explosionClone, 0.5f);
		Destroy (gameObject, 0.5f);

	}
		
	public virtual void DroneDeath(){
		StartCoroutine("DeathAnim");
	}

	public virtual void DestructionOccur(){
		enemyHealth.fillAmount -= 0.09f;

		if(enemyHealth.fillAmount <= 0){
			DroneDeath ();
		}
	}
}
