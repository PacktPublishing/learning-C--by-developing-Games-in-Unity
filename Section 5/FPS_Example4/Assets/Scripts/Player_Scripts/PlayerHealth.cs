using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {
	public Image playerHealth;
	public Text deadText; 

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "laser"){
			playerHealth.fillAmount -= 0.09f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth.fillAmount <= 0){
			//we must first deparent the camera in order to avoid destroying the camera with the player
			GameObject objectToSave = gameObject.transform.GetChild (1).gameObject;
			objectToSave.transform.parent = null;
			Destroy (gameObject);
			deadText.text = "YOU HAVE DIED!!!!";
		}
	}
}
