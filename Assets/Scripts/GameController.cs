using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController> {

	private bool blueCleared = false;
	private bool redCleared = false;
	private bool greenCleared = false;

	public GameObject greenLayer;
	public GameObject blueLayer;
	public GameObject redLayerBg;
	public GameObject redLayerFg;
	// Use this for initialization
	void Start () {
		 greenLayer = Resources.Load("Prefabs/GreenLayer")as GameObject;
		 blueLayer = Resources.Load("Prefabs/BlueLayer")as GameObject;
		 redLayerBg = Resources.Load("Prefabs/RedLayerBg")as GameObject;
		 redLayerFg = Resources.Load("Prefabs/RedLayerFg")as GameObject;
	}

	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnLevelWasLoaded(int level){
		if(level == 0){
			if (greenCleared){
				//greenLayer.SetActive(true);
				GameObject.Instantiate(greenLayer,greenLayer.transform.position,greenLayer.transform.rotation);
			}
			if (redCleared){
				/*redLayerBg.SetActive(true);
				redLayerFg.SetActive(true);*/
				GameObject.Instantiate(redLayerBg);
				GameObject.Instantiate(redLayerFg);
			}
			if (blueCleared){
				/*blueLayer.SetActive(true);*/
				GameObject.Instantiate(blueLayer);
			}
		}
	}


	public void LevelCompleted(int level){
		switch (level){
		case 1:
			blueCleared = true;
			break;
		case 2:
			redCleared = true;
			break;
		case 3:
			greenCleared = true;
			break;
		}
	}
}
