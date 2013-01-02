using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int health;
	private Vector3 normalCamPosition;
	private Quaternion normalCamRotation;
	private bool normalCam = true;
	
	// Use this for initialization
	void Start () {
		health = 5;
		normalCamPosition = Camera.main.transform.position;
		normalCamRotation = Camera.main.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the ship based on horizontal movement.
		//transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
		//transform.Translate(0, 0, Input.GetAxis("Vertical"));
		rigidbody.AddForce(transform.forward * Input.GetAxis("Vertical") * 1000);
		rigidbody.AddTorque(0, Input.GetAxis("Horizontal") * 1000, 0);
		
		
		// Toggle the camera location/direction when Numpad 0 is pressed
		if (Input.GetKeyDown(KeyCode.Equals)) {
			if (normalCam) {
				Camera.main.transform.position = new Vector3(0, 100, -200);
				Camera.main.transform.rotation = Quaternion.Euler(22, 0, 0);
			} else {
				Camera.main.transform.position = normalCamPosition;
				Camera.main.transform.rotation = normalCamRotation;
			}
			normalCam = !normalCam;
		}
	}
	
	void OnCollisionEnter(Collision collision){
		health--;
		if (health <= 0){
			//Instantiate(deathAnimation, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

}
