using UnityEngine;
using System.Collections;

public class Power_up : MonoBehaviour {
	public int flashing = 0;
	public GameObject playerShip;
	
	// Use this for initialization
	void Start () {
		float lifetime = 10.0F;
		Invoke ("Flash", 7);
 		Destroy (gameObject, lifetime);
		playerShip = (GameObject)GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
		if (flashing == 1){
			renderer.enabled = false;
			flashing = 2;
		}else if(flashing ==2){
			renderer.enabled = true;
			flashing = 1;
		}

	}
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag("Player")){
			Score_Counter s = (Score_Counter) GameObject.Find("Score").GetComponent("Score_Counter");
			s.score+=20;
			ShootControls shootControls = (ShootControls) playerShip.GetComponentInChildren<ShootControls>();
			shootControls.fireRate -= .05f;
			Destroy(gameObject);
		}
		
	}
	
	void Flash(){
		flashing = 1;
	}
}
