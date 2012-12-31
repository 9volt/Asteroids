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
		transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
		transform.Translate(0, 0, Input.GetAxis("Vertical"));
		Vector3 position = transform.position;
		if (Input.GetButtonUp("Fire1")) {
			Instantiate(laserShot, position, transform.rotation);	
		}
//		if (position.x > 100){
//			transform.Translate(-100, 0, position.z);	
//		} else if (position.z > 100){
//			transform.Translate(position.x, 0, -100);	
//		} else if (position.x < -100){
//			transform.Translate(100, 0, position.z);	
//		} else if (position.z < -100){
//			transform.Translate(position.x, 0, 100);	
//		}
	}
}
