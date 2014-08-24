using UnityEngine;
using System.Collections;

public class Ballon : MonoBehaviour {

	private AudioSource audioSource;
	public float impulseForce;
	private Animator anim;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0,impulseForce));
			audioSource.Play();
			anim.SetBool("Explode",true);
			Destroy(gameObject,1f);
		}
	}
}
