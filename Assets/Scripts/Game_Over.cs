using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {
	public PlayerController target;
	
	// Use this for initialization
	void Awake () {
		guiText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (target.health <= 0){
			guiText.material.color = Color.red;
			guiText.enabled = true;
		}
	
	}
}
