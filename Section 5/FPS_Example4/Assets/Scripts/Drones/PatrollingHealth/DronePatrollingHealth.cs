using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DronePatrollingHealth : MonoBehaviour {

	public Image enemyHealth;
	public GameObject explosion; 

	void Update(){
		if(enemyHealth.fillAmount <= 0){
			GameObject explosionClone = Instantiate (explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (explosionClone, 0.5f);
			Destroy (gameObject, 0.5f);
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bullet"){
			enemyHealth.fillAmount -= 0.09f;
		}
	}
}
