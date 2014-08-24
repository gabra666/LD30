using UnityEngine;
using System.Collections;

public class BirdDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == LayerMask.NameToLayer ("Bird")) {
			GameObject.Destroy(collision.gameObject);
		}
	}
}
