using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSound: MonoBehaviour {

	public AudioClip audioClip;
	AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.tag == "Block") {
			audioSource.PlayOneShot(audioClip);
		}
	}

}