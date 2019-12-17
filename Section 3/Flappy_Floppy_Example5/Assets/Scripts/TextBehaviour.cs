using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we will need to add the UnityEngine.UI namespace
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour {
	public bool gameBegan = false;
	//lets grab the player controller when ready to get the text to display game over depending on player death
	public PlayerController deathHappened; 
	public GameObject restartButton; 

	// Update is called once per frame
	void Update () {
		//when button is clicked and bool is true then set the empty text 
		if (gameBegan == true){
			PlayStatus ();
		}
		//create a separate conditional to handle death text 
		if (deathHappened.playerDeath == true) {
			DeathText ();
		}
	}

	//this function will be passed to our button and once it is clicked, then the game begins. We must also disable the start button
	public void ClickToStart(){
		gameBegan = true;
		GameObject startButton = GameObject.Find ("StartButton");
		startButton.SetActive (false);
	}

	//we will set the text value to an empty string when the game starts 
	void PlayStatus(){
		Text displayText = this.gameObject.GetComponent<Text> ();
			displayText.text = " ";
	}

	//create another method to display the death text. We will need a public variable in this case to get the restart button to re-enable. 
	  //we cannot grab a disabled object with the Find method. 
	void DeathText(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = "You have died, click to try again!";
		restartButton.SetActive (true);
	}


}
