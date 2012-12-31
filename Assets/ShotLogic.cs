using UnityEngine;
using System.Collections;

public class ShotLogic : MonoBehaviour {
	private float moveSpeed;
	
	// Use this for initialization
	void Start () {
		moveSpeed = 50;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, Time.deltaTime * moveSpeed);
	}
}
