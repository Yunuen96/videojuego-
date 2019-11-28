using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepmusic : MonoBehaviour {

	public static keepmusic keepMusic;

	void Awake(){
		if (keepMusic == null) {
			keepMusic = this;
			DontDestroyOnLoad (gameObject);
		} else if (keepMusic != this) {
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
