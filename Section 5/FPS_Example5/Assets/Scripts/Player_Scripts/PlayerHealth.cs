using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {
	public Image playerHealth;
	public Text deadText; 

	//grab reference to the timer 
	private Timer timesCheck; 

	//start method to grab the timer script
	void Start(){
		timesCheck = GameObject.Find ("Timer").GetComponent<Timer> ();
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "laser"){
			playerHealth.fillAmount -= 0.09f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//check if either the players health is out or if time is up to kill the player 
		if (playerHealth.fillAmount <= 0 || timesCheck.timesUp == true){
			//we must first deparent the camera in order to avoid destroying the camera with the player
			GameObject objectToSave = gameObject.transform.GetChild (1).gameObject;
			objectToSave.transform.parent = null;
			Destroy (gameObject);
			deadText.text = "YOU HAVE DIED!!!!";
		}
	}
}
