using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	private float speed;
	private float maxSpeed = 5;
	
	// Use this for initialization
	void Start () {
		speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the ship based on horizontal movement.
		transform.Rotate(0, 0, -1 * Input.GetAxis("Horizontal"));
		transform.Translate(0, Input.GetAxis("Vertical"), 0);
		Vector3 position = transform.position;
		if (position.x > 100){
			transform.Translate(-100, position.y, 0);	
		} else if (position.y > 100){
			transform.Translate(position.x, -100, 0);	
		} else if (position.x < -100){
			transform.Translate(100, position.y, 0);	
		} else if (position.y < -100){
			transform.Translate(position.x, 100, 0);	
		}
	}
}
