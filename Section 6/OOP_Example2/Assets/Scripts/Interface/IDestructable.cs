using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//capital I stands for interface. Interfaces usually end with -able 
//interfaces are commonly used when two completely different objects, are to have the same functionality 
 //in this case here the ability for both drones and metal crates to be destroyed 

//this is no longer a class, it is an interface 
public interface IDestructable {
	//the method signature must be implemented to any script utilizing the interface 
	void DestructionOccur (); 

	//we will put this script onto the bullet prefab so the destruction code isnt duplicated 



}
