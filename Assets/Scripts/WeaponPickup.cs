using UnityEngine;
using System.Collections;

public class WeaponPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Add code to prevent players running up to player and grabbing their weapon.
	// There is a potential for another player to run up to a player and hit the pickup weapon button and snatch it out of their hands.
	// Not sure how unity handels scope of code attached to objects and multilpe instances of same object type.
	
	void OnTriggerStay(Collider other) {
		if (other.gameObject.name == "First Person Controller" && Input.GetKeyDown ("e")) {
			gameObject.transform.parent = other.transform;
			Transform WeaponMount = other.transform.FindChild ("WeaponMount");
			
			gameObject.transform.localPosition = WeaponMount.localPosition;
			gameObject.transform.localEulerAngles = WeaponMount.localEulerAngles;
			gameObject.rigidbody.isKinematic = true;
			
			gameObject.GetComponent<FireProjectileWeapon>().isEquiped = true;
			
			print ("I want to pick up the weapon.");	
		}
		
		//This drops the object
		if (other.gameObject.name == "First Person Controller" && Input.GetKeyDown ("f")) {
			gameObject.transform.parent = null;
			gameObject.rigidbody.isKinematic = false;
			
			gameObject.GetComponent<FireProjectileWeapon>().isEquiped = false;
		}	
	}
}