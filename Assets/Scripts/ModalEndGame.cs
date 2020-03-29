using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModalEndGame : MonoBehaviour {

	public GameObject modalendgamepanel;

	private static ModalEndGame modalendgame;

    public static ModalEndGame Instance () {
        if (!modalendgame) {
            modalendgame = FindObjectOfType(typeof (ModalEndGame)) as ModalEndGame;
            if (!modalendgame)
                Debug.LogError ("There needs to be one active ModalEndGame script on a GameObject in your scene.");
        }
        return modalendgame;
    }

    public void redirectEndGame() {
    	
		if (RandomStart.win)
			SceneManager.LoadScene("Congratulations");
		else
			SceneManager.LoadScene("GameOver");
		Debug.Log(RandomStart.win);
    }

    public void activeEndGamePanel() {
    	modalendgamepanel.SetActive (true);
    }


}
