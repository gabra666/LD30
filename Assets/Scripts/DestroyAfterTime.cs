using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

	// Use this for initialization
	public float destroyTime;
	void Start () {
		Destroy(gameObject,destroyTime);
	}
}
