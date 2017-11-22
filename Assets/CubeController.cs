﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	public AudioClip audioClip;
	AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}


	}

	void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.tag == "Block") {
			audioSource.PlayOneShot(audioClip);
		}
	}

}