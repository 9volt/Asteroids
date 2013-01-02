using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int health;
	
	// Use this for initialization
	void Start () {
		health = 5;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the ship based on horizontal movement.
		//transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
		//transform.Translate(0, 0, Input.GetAxis("Vertical"));
		rigidbody.AddForce(transform.forward * Input.GetAxis("Vertical") * 1000);
		rigidbody.AddTorque(0, Input.GetAxis("Horizontal") * 1000, 0);
	}
	
	void OnCollisionEnter(Collision collision){
		health--;
		if (health <= 0){
			//Instantiate(deathAnimation, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

}
