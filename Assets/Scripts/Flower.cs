using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {


	private AudioSource audioSource;
	public float impulseForce;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0,impulseForce));
			audioSource.Play();
			//Destroy(gameObject,1f);
		}
	}
}
