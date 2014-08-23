using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public int level;

	private void OnCollisionEnter2D(Collision2D collision2d){
		if(collision2d.gameObject.layer == LayerMask.NameToLayer("Player")){
			Application.LoadLevel(level);
		}
	} 
}
