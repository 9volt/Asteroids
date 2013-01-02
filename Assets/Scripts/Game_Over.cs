using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {
	public PlayerController target;
	
	// Use this for initialization
	void Awake () {
		this.guiText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (target.health <= 0){
			this.guiText.material.color = Color.red;
			this.guiText.enabled = true;
		}
	
	}
}
