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
	
	// Add code to remove trigger once picked up
	// Add code todrop item and add trigger back to object when player hits button todrop item (add it to update).
	
	void OnTriggerStay(Collider other) {
		if (other.gameObject.name == "First Person Controller" && Input.GetKeyDown ("e")) {
			gameObject.transform.parent = other.transform;
			Transform WeaponMount = other.transform.FindChild ("WeaponMount");
			
			gameObject.transform.localPosition = WeaponMount.localPosition;
			gameObject.transform.localEulerAngles = WeaponMount.localEulerAngles;
			print ("I want to pick up the weapon.");	
		}
		
		//This drops the object
		if (other.gameObject.name == "First Person Controller" && Input.GetKeyDown ("f")) {
			gameObject.transform.parent = null;
		}	
	}
}
