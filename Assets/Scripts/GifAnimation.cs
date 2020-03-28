using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifAnimation : MonoBehaviour {

	private Vector3 end;
	private float speed = 0.02f;


	void Start() {
		end = this.gameObject.transform.position + Vector3.right * 40f;
	}

	void Update() {
		this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, end, speed);
    }
}
