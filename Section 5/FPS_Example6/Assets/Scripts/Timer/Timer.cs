using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	private Text timerText; 
	public bool timesUp = false;
	private float deplete = 0.5f; 
	private float currentTime = 30.0f; 
	// Use this for initialization
	void Start () {
		timerText = gameObject.GetComponent<Text> ();
		timerText.text = currentTime.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		//set current time equal to zero if it goes negative 
		if (currentTime <= 0){
			currentTime = 0;
			timesUp = true; 
		}
		timerText.text = currentTime.ToString ();
		//multiply deplete by time.deltatime to get a more fluid decrease 
		currentTime -= deplete * Time.deltaTime;

	}
}
