using UnityEngine;
using System.Collections;

public class GameWatch : MonoBehaviour {
	public GameObject asteroid;
	private int totalAsteroids;

	// Use this for initialization
	void Start () {
		totalAsteroids = 3;
		for(int i = 0; i < totalAsteroids; i++){
			SpawnAsteroid();
		}
	}
	
	void SpawnAsteroid(){
		Vector3 pos = new Vector3(Random.Range(-200, 200), 0, Random.Range(-100, 100));
		Quaternion rot = Quaternion.Euler(0, Random.Range(0, 360), 0);
		GameObject a = (GameObject)Instantiate(asteroid, pos, rot);
		a.rigidbody.AddForce(a.transform.forward * 100000);
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject ps in GameObject.FindGameObjectsWithTag("particleSystems")){
			if(!ps.particleSystem.IsAlive()){
				Destroy(ps);
			}
		}
		int count = GameObject.FindGameObjectsWithTag("asteroid").Length;
		if (count < totalAsteroids){
			SpawnAsteroid ();	
		}
	}
}
