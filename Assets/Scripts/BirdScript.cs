using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {


	public float speed;
	public GameObject pooPoint;
	public GameObject poo;
	public float pooTime;
	private float lastPooTime;
	public AudioClip[] sounds;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		Poo();
	}

	private void Move(){
		transform.position = new Vector2(transform.position.x+ (-speed*Time.deltaTime),transform.position.y);
	}

	private void Poo(){
		if ((Time.time - lastPooTime) > pooTime) {
			lastPooTime = Time.time;
			audioSource.clip = sounds[0];
			audioSource.Play();
			Instantiate(poo,pooPoint.transform.position,pooPoint.transform.rotation);
		}

	}


}
