using UnityEngine;
using System.Collections;

public class ShootControls : MonoBehaviour {
	public GameObject laserShot;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Instantiate(laserShot, transform.position, transform.rotation);	
		}

	}
}
