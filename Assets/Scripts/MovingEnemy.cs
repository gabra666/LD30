using UnityEngine;
using System.Collections;

public class MovingEnemy : MonoBehaviour {
	
	public float jumpForce;
	public float jumpTime;
	private float lastJumpTime;
	public AudioClip[] sounds;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Jump();
	}

	private void Jump(){
		if ((Time.time - lastJumpTime) > jumpTime) {
			lastJumpTime = Time.time;
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
			audioSource.clip = sounds[0];
			audioSource.Play();
		}

	}
}
