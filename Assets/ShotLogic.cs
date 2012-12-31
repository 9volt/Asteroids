using UnityEngine;
using System.Collections;

public class ShotLogic : MonoBehaviour {
	private float moveSpeed;
	
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward * 2000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void onCollisionEnter(Collision collision){
		Debug.Log("BOOM");	
	}
	
}
