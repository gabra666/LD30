using UnityEngine;
using System.Collections;

public class Poo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			Invoke ("RestartLevel",1);
			
		}
	}

	void RestartLevel(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
