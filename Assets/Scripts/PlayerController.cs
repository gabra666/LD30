using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float move;
	public float speed;

	private bool grounded;
	public Transform groundCheck;
	private float groundRadius = 0.1f;
	public LayerMask groundLayers;
	public float jumpForce = 700f;
	private bool facingRight = true;
	public AudioClip[] sounds;
	private AudioSource audioSource;

	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
		grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,groundLayers);
		anim.SetBool("Grounded",grounded);
		anim.SetFloat("VerticalSpeed",rigidbody2D.velocity.y);
		if(grounded && Input.GetKeyDown(KeyCode.Space)){
			anim.SetBool("Grounded",false);
			audioSource.clip = sounds[1];
			audioSource.Play();
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		move = Input.GetAxis("Horizontal");
		anim.SetFloat("Move",Mathf.Abs(move));
		rigidbody2D.velocity = new Vector2(move * speed, rigidbody2D.velocity.y);

		if(move > 0 && !facingRight){
			Flip ();
		}
		else if(move < 0 && facingRight){
			Flip ();
		}
	}

	private void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == LayerMask.NameToLayer ("Poo") || collision.gameObject.layer == LayerMask.NameToLayer ("Enemy")) {
			audioSource.clip = sounds[0];
			audioSource.Play();
			Invoke ("RestartLevel",2);
		}
	}

	
	private void RestartLevel(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
