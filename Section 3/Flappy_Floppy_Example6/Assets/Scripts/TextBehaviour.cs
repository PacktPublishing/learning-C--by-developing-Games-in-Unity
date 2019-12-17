using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehaviour : MonoBehaviour {
	//we will change this script a bit by getting rid of the gameBegan boolean, the ButtonHandler script will handle this now and instead we will get the
	 //reference to the button handler script 
	public ButtonHandler buttonAction;
	public PlayerController playerStatus; 
	public GameObject restartButton; 
	public GameObject startButton; 
	// Update is called once per frame
	void Update () {
		if (buttonAction.startGame == true){
			PlayStatus ();
		}
		if (playerStatus.playerDeath == true) {
			DeathText ();
		}
		//add one more conditional for when the player wins
		if(playerStatus.playerWin == true){
			WinText ();
		}
	}
		
	//we also do not need the public click to start method 
		
	void PlayStatus(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = " ";
		startButton.SetActive (false);
	}
		
	void DeathText(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = "You have died, click to try again!";
		restartButton.SetActive (true);
	}

	//create text when the user has won
	void WinText(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = "You win!, click to play again";
		restartButton.SetActive (true);
	}

}
