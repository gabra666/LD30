using UnityEngine;
using System.Collections;

public class BottomLimit : MonoBehaviour {

	private void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			Application.LoadLevel(0);
		}
	}
}
