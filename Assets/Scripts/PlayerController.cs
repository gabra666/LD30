using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float move;
	public float speed;

	private bool grounded;
	public Transform groundCheck;
	private float groundRadius = 0.2f;
	public LayerMask groundLayers;
	public float jumpForce = 700f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,groundLayers);

		if(grounded && Input.GetKeyDown(KeyCode.Space)){
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(move * speed, rigidbody2D.velocity.y);
		if(move > 0){

		}
		if(move < 0){

		}
	}
}
