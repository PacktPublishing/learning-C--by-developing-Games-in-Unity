using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {
	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private Transform spawnArea; 
    //add a timer to control how quickly bullets will spawn 
	public int timer = 0; 

	//IN ORDER TO GET ANIMATIONS TO WORK THIS WAY YOU MUST FIRST SET THE ANIMATIONS TO LEGACY 
	 //in order to set animations to legacy first you click on the animation in the project window, go to the inspector window and in the drop down
	 //on the upper right hand corner, select debug, from there you should have an unchecked box called Legacy, select it and this should work. 
	public Animation animClip; 

	//we will now substitute our timer with a boolean, the reason why is because now that we are using a corountine we can set this bool to trigger
	  //after the animation finishes playing 
	bool canShoot = true; 

	void Start(){
		animClip = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1;
		SpawnBullet ();
	}

	void SpawnBullet(){
		//change conditional to include can shoot
		if (Input.GetMouseButtonDown(0) && canShoot == true){
			GameObject bulletClone = Instantiate (bullet, spawnArea.position, spawnArea.rotation);
			bulletClone.GetComponent<Rigidbody> ().AddForce (spawnArea.transform.up * 800);
			//set canshoot to false
			canShoot = false;
			//set the coroutine 
			StartCoroutine ("RecoilAnim");
			Destroy (bulletClone, .5f);
		}

	}

	//when using a corountine, it will run until a sequence is completed and will continue on after the sequence is done or after a 
	   //specific amount of time. 
	//Corountines must happen in a single frame in update 
	//here we are setting the animation to be played and once the animation has finished, we will set the canShoot boolean to true again
	//this can allow for a much more smoother transition from the time our animation begins to when it ends
	//this will also make sure that the player cannot shoot another bullet until the animation has finished 
	IEnumerator RecoilAnim(){
		animClip.Play ("Gun_Recoil");
		yield return new WaitForSeconds (animClip.clip.length);
		canShoot = true;;
	}
}
