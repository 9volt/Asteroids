using UnityEngine;
using System.Collections;

public class ShotLogic : MonoBehaviour {
	private float moveSpeed;
	public GameObject explosion;
	
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward * 4000);
		Destroy (gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision){
		Instantiate(explosion, transform.position, Quaternion.Inverse (transform.rotation));
		Destroy (gameObject);
		Destroy (gameObject, 2);
	}
	
}
