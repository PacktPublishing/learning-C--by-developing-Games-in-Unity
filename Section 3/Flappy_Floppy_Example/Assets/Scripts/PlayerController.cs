using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//There are several built in Unity methods that can be used. Right when we create any script you will always see two methods already created
	//The first is the Start method. This method is used to initialize any variables or set any objects at the beginning of the game.
	//The Start method is called once in the lifetime of the script.

	// Use this for initialization
	void Start () {
		
	}

	//The Update method runs code every frame during the game and is used to implement any kind of game behaviour 
	//This is typically where we call other methods and put code in to be continuously run
	//Try to avoid putting a lot of code for many different purposes in this method, it can become difficult to read and we will have an issue 
	  //called "spaghetti code" 

	// Update is called once per frame
	void Update () {
		//We know that we can use our console to track down bugs and also view errors. One way we can find potential errors in our code 
		//through the console is by using Print statements. Similarly to Console.Write(), if a block of code is run without any errors, a print statement
		  //should hit, if a print statement is not printing anything to the console it can suggest that our code broke before the print statement hit
		  //or that there is not a potential error with that block of code if everything executes correclty.
		print("its working!");
	}

	//Awake is similar to Start but the main difference is that Awake() initializes any game variables or game states before the 
	  //game even begins. Start on the other hand begins as soon as the game has started to run. 
	//Just like Start, Awake can only be called once in the instance of the script's life time 
	//It is best practice to use Awake to set up references between scripts and Start to pass information
	  //back and forth, since Awake is always called before Start functions 

	void Awake(){
		
	}

	//There are many other different methods you can use with Unity and they are all listed on the Unity documentation
	//We will go over some other methods as we progress 
}
