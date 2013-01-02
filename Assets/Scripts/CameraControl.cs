using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public Vector3 normalCamPosition;
	public Quaternion normalCamRotation;
	public bool normalCamEnabled = true;
	
	// Use this for initialization
	void Start () {
		normalCamPosition = Camera.main.transform.position;
		normalCamRotation = Camera.main.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		// Toggle the camera location/direction when Numpad 0 is pressed
		if (Input.GetKeyDown(KeyCode.Equals)) {
			if (normalCamEnabled) {
				Camera.main.transform.position = new Vector3(0, 100, -200);
				Camera.main.transform.rotation = Quaternion.Euler(22, 0, 0);
			} else {
				Camera.main.transform.position = normalCamPosition;
				Camera.main.transform.rotation = normalCamRotation;
			}
			normalCamEnabled = !normalCamEnabled;
		}
	}
}
