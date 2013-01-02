using UnityEngine;
using System.Collections;

public class astroidScript : MonoBehaviour {
	private int health;
	public GameObject deathAnimation;
	public GameObject asteroid;
	public int size;
	
	// Use this for initialization
	void Start () {
		health = 3;
		transform.localScale = new Vector3(size * 10, size * 10, size * 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision){
		health--;
		if (health <= 0){
			Instantiate(deathAnimation, transform.position, transform.rotation);
			//Create new asteroids
			for(int i = size; i > 0; i--){
				CreateAsteroid();	
			}
			Destroy(gameObject);
		}
	}
	
	void CreateAsteroid(){
		Vector3 pos = new Vector3(transform.position.x + Random.Range(-10, 10), 0, transform.position.z + Random.Range(-10, 10));
		Quaternion rot = Quaternion.Euler(0, Random.Range(0, 360), 0);
		GameObject a = (GameObject)Instantiate(asteroid, pos, rot);
		a.rigidbody.AddForce(a.transform.forward * 100000);
		a.GetComponent<astroidScript>().size = size - 1;
	}
}
