﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestModalEndGame : MonoBehaviour {

	private ModalEndGame modalendgame;

	void Awake() {
		modalendgame = ModalEndGame.Instance();
	}

	public void acivateEndGamePanel() {
		modalendgame.activeEndGamePanel();
	}

	public void loadEndGame() {
		modalendgame.redirectEndGame();
	}

}
