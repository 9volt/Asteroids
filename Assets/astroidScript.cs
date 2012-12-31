using UnityEngine;
using System.Collections;

public class astroidScript : MonoBehaviour {
	private int health;
	public GameObject deathAnimation;
	
	// Use this for initialization
	void Start () {
		health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision){
		health--;
		if (health <= 0){
			Instantiate(deathAnimation, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
