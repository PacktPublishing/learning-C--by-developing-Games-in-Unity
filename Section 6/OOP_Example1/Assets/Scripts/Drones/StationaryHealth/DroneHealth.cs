using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneHealth : MonoBehaviour {
	//when using Inheritance it normally works best between two game objects that are related in some way. In this case we have two kinds of drones, 
	  //one which is stationary and the other which is patrolling. An example of a common attribute between them is they both have health, take damange,
	  //from a bullet, and also die in a firey explosion. As you probably have seen in the previous section, we had two scripts for both gameobjects that 
	  // were quite similar. We can actually have one script use the code from a base script. This is the form of OOP known as inheritance. Here we can 
	  //create a simple usage of inheritance between these two scripts.

	//we must change the names of these variables to PROTECTED so child classes can access them 
	[SerializeField]
	protected Image enemyHealth;
	[SerializeField]
	protected GameObject explosion; 
	[SerializeField]
	protected Animation animClip; 

	//we will also need to add protected to the methods as well otherwise they cannot be accessed by the child class 
	protected virtual void Start(){
		animClip = GetComponent<Animation> ();
	}

	//when using inhertiance the base or "Parent" class must have virtual methods for the child class to access them. 
	protected virtual void Update(){
		if(enemyHealth.fillAmount <= 0){
			DroneDeath ();
		}
	}

	protected virtual void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bullet"){
			enemyHealth.fillAmount -= 0.09f;
		}
	}

	//Coroutines can be virtual or overriden however in this example there are a few issues when doing this so we will leave this as is in both scripts
	IEnumerator DeathAnim(){
		animClip.Play ("Drone_Death");
		yield return new WaitForSeconds (animClip.clip.length);
		GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
		Destroy (explosionClone, 0.5f);
		Destroy (gameObject, 0.5f);

	}

	//we will use this public virtual method to house the cortoutine 
	public virtual void DroneDeath(){
		StartCoroutine("DeathAnim");
	}

}
