using UnityEngine;
using System.Collections;

public class FireProjectileWeapon : MonoBehaviour {
	
	public float projVelocity; //Meters per second
	public GameObject projPrefab;
	public float rateOfFire;
	public float inaccuracy;
	
	private float fireTimer;
	
	// Use this for initialization
	void Start () {
		fireTimer = Time.time + rateOfFire;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.DrawLine(transform.position, transform.position + transform.forward, Color.red);
		
		if (Time.time > fireTimer) {

            GameObject projectile;
			Vector3 muzzlevelocity = transform.forward;

			if (inaccuracy != 0) {

                Vector2 rand    = Random.insideUnitCircle;
				muzzlevelocity += new Vector3(rand.x, rand.y, 0) * inaccuracy;

            }

 			muzzlevelocity = muzzlevelocity.normalized * projVelocity;
            projectile = Instantiate(projPrefab, transform.position, transform.rotation) as GameObject;
            projectile.GetComponent<ProjectileScript>().muzzleVelocity = muzzlevelocity;
            fireTimer = Time.time + rateOfFire;
        } else {	
			return;
		}
	}//void Update() {}		
}