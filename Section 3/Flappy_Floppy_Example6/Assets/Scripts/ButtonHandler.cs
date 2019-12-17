using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//call UI namespace 
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour {
	//we will use this button handler to show how OnClick listeners can also be used to get button input 
	//we will change our code around a bit to fit both our new restart button and our start button 
	public Button startButton;
	public Button restartButton; 
	public bool startGame = false;
	public bool restartGame = false;

	//we only need start because the buttons will only handle one operation 
	void Start () {
		Button sButton = startButton.GetComponent<Button> ();
		sButton.onClick.AddListener (StartGame);

		Button rButton = restartButton.GetComponent<Button> ();
		rButton.onClick.AddListener (Restart);
	}
	
	void StartGame(){
		startGame = true; 
	}

	//when our restart button is clicked, we will load up our scene again to restart it from the beginning
	//grab our scene by the name in order to load it

	public void Restart(){
		SceneManager.LoadScene ("Scene_One");
	}
}
