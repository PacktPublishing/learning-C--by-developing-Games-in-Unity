using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneStationaryHealth : MonoBehaviour {
	public Image enemyHealth;
	public GameObject explosion; 
	public Animation animClip; 

	void Start(){
		animClip = GetComponent<Animation> ();
	}

	void Update(){
		if(enemyHealth.fillAmount <= 0){
			//we will grab the fill amount of the image in order to make the image decrease each time the player or enemy is hit, we must use world space
			 //in order to set up the enemy health bar. The enemy drone will explode when dead and the camera for the player will just remain when dead
//			GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
//			Destroy (explosionClone, 0.5f);
			StartCoroutine("DeathAnim");
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bullet"){
			enemyHealth.fillAmount -= 0.09f;
		}
	}

	IEnumerator DeathAnim(){
		animClip.Play ("Drone_Death");
		yield return new WaitForSeconds (animClip.clip.length);
		GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
		Destroy (explosionClone, 0.5f);
		Destroy (gameObject, 0.5f);

	}

}
