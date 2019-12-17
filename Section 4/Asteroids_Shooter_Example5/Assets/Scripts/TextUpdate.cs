using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//grab the UI 
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour {
	//take the text as a game object
	[SerializeField]
	private GameObject text; 

	//create a text variable to store the component in 
	private Text scoreText; 

	//and also an int to update the score by 1
	public int scoreNum = 0; 
	// Use this for initialization
	void Start () {
		scoreText = text.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score " + scoreNum.ToString ();

	}
}
