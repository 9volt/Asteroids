using UnityEngine;
using System.Collections;

public class GameWatch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject ps in GameObject.FindGameObjectsWithTag("particleSystems")){
			if(!ps.particleSystem.IsAlive()){
				Destroy(ps);
			}
		}
	
	}
}
