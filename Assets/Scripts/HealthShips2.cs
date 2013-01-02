using UnityEngine;
using System.Collections;

public class HealthShips2 : MonoBehaviour {
	public PlayerController target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (target.health <= 2){
			Destroy(gameObject);
		}
	}
}
