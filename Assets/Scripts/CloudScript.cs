using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour
{

	public Sprite originalSprite;
	public Sprite steppedSprite;
	private SpriteRenderer spriteRenderer;
	private AudioSource sound;
		// Use this for initialization
		void Start ()
		{
			spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
			sound = gameObject.GetComponent<AudioSource>();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	private void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			spriteRenderer.sprite = steppedSprite;
			sound.Play();
			}
		}

	private void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			spriteRenderer.sprite = originalSprite;
		}
	}



}
