using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public int level;
	private GameController gameController;

	private void Start(){
		gameController = GameController.GetInstance;
	}

	private void OnCollisionEnter2D(Collision2D collision2d){
		if(collision2d.gameObject.layer == LayerMask.NameToLayer("Player")){
			gameController.LevelCompleted(Application.loadedLevel);
			Application.LoadLevel(level);
		}
	} 
}
