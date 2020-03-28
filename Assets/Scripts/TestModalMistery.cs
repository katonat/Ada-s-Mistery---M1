using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestModalMistery : MonoBehaviour {

	private ModalMistery modalMistery;

	void Awake() {
		modalMistery = ModalMistery.Instance();
	}

	public void showMistery() {
		modalMistery.mistery();
	}

}
