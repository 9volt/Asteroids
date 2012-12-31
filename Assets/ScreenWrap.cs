using UnityEngine;
using System.Collections;

public class ScreenWrap : MonoBehaviour {
	private int xLength;
	private int zHeight;
	
	// Use this for initialization
	void Start () {
		xLength = 200;
		zHeight = 100;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		// Move ship to other side of screen
		if (position.x > xLength){
			transform.position = new Vector3(-1 * xLength, 0, position.z);	
		} else if (position.z > zHeight){
			transform.position = new Vector3(position.x, 0, -1 * zHeight);	
		} else if (position.x < -1 * xLength){
			transform.position = new Vector3(xLength, 0, position.z);	
		} else if (position.z < -1 * zHeight){
			transform.position = new Vector3(position.x, 0, zHeight);	
		}
	}
}
