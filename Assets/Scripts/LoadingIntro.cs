using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingIntro : MonoBehaviour {

	[SerializeField]
	private float delay = 6f;
	[SerializeField]
	private float timElapesed;

	private void Update() {
		timElapesed += Time.deltaTime;

		if(timElapesed > delay) {
			SceneManager.LoadScene("StartGame");
		}
	}




}
