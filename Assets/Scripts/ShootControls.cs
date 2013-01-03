using UnityEngine;
using System.Collections;

public class ShootControls : MonoBehaviour {
	public GameObject laserShot;
	public float fireRate = 0.25f;
	private float nextFire = 0.0f;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject shot = (GameObject) Instantiate(laserShot, transform.position, transform.rotation);	
			//Somehow add more force to the shot
			//Debug.Log(transform.parent.rigidbody.velocity + " " + transform.forward);
			int curSpeed = (int)transform.parent.rigidbody.velocity.magnitude * 100;
			shot.GetComponent<Rigidbody>().AddForce(transform.forward * (6000 + curSpeed));
		}

	}
}
