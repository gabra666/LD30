using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour
{
		private static T instance;

		public static T GetInstance {
				get {
						if (instance == null) {
								GameObject singletonObject = new GameObject ();
								instance = singletonObject.AddComponent<T> ();
								singletonObject.name = "(Singleton) " + typeof(T).ToString ();
								DontDestroyOnLoad (singletonObject);
						}
						return instance;
				}
		}

}
