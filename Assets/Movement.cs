using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public GameObject laserShot;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the ship based on horizontal movement.
		//transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
		//transform.Translate(0, 0, Input.GetAxis("Vertical"));
		rigidbody.AddForce(transform.forward * Input.GetAxis("Vertical") * 1000);
		rigidbody.AddTorque(0, Input.GetAxis("Horizontal") * 1000, 0);
		Vector3 position = transform.position;
		if (Input.GetButtonDown("Fire1")) {
			Instantiate(laserShot, position, transform.rotation);	
		}

	}
}
