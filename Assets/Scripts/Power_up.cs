using UnityEngine;
using System.Collections;

public class Power_up : MonoBehaviour {
	public int flashing = 0;
	
	// Use this for initialization
	void Start () {
		float lifetime = 10.0F;
		Invoke ("Flash", 7);
 		Destroy (gameObject, lifetime);
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
			Destroy(gameObject);
			Score_Counter s = (Score_Counter) GameObject.Find("Score").GetComponent("Score_Counter");
			s.score+=20;
		}
		
	}
	
	void Flash(){
		flashing = 1;
	}
}
