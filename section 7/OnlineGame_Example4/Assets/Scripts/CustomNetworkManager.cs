using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//call networking 
using UnityEngine.Networking;
//UI
using UnityEngine.UI;
//will need this in order to stop prefabs from being the same for all clients 
using UnityEngine.Networking.NetworkSystem;

public class CustomNetworkManager : NetworkManager {
	//in order to create a character select screen we will need to create our own custom network manager.
	  //have this script inherit from network manager and replace the current network manager with this script 
	//when attached this script should have all the same attributes shown in the editor as the previous component 
	public Button characterChoiceOne;
	public Button characterChoiceTwo;
	public Button characterChoiceThree; 

	public Canvas SelectCanvas; 

	int prefabsArray = 2; 
	// Use this for initialization
	void Start () {
		characterChoiceOne.onClick.AddListener(delegate {CharacterPick (characterChoiceOne.name);});
		characterChoiceTwo.onClick.AddListener(delegate {CharacterPick (characterChoiceTwo.name);});
		characterChoiceThree.onClick.AddListener(delegate {CharacterPick (characterChoiceThree.name);});

	}

	void CharacterPick(string charName){
		switch (charName) {
		case "Capsule":
			prefabsArray = 2;
			break;
		case "Cube":
			prefabsArray = 3;
			break;
		case "Sphere":
			prefabsArray = 4;
			break;
		default: 
			break;
		}


		playerPrefab = spawnPrefabs [prefabsArray];
	}

	public override void OnClientConnect(NetworkConnection conn){
		SelectCanvas.enabled = false; 

		IntegerMessage msg = new IntegerMessage (prefabsArray);

		if (!clientLoadedScene){
			ClientScene.Ready (conn);
			if (autoCreatePlayer) {
				ClientScene.AddPlayer (conn, 0, msg);
			}
		}
	}

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader){
		int id = 0;

		if (extraMessageReader != null){
			IntegerMessage i = extraMessageReader.ReadMessage<IntegerMessage> ();
			id = i.value;
		}

		GameObject playerPrefab = spawnPrefabs [id];

		GameObject player; 
		Transform startPos = GetStartPosition ();

		if (startPos != null) {
			player = (GameObject)Instantiate (playerPrefab, startPos.position, startPos.rotation);
		} else {
			player = (GameObject)Instantiate (playerPrefab, Vector3.zero, Quaternion.identity);
		}
		NetworkServer.AddPlayerForConnection (conn, player, playerControllerId);
	}
}
