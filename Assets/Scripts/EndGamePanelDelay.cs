using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGamePanelDelay : MonoBehaviour {

    [SerializeField]
    private float delay = 3f;
    [SerializeField]
    private float timElapesed;
    private float delta;
    public GameObject endGamePanel;
   
    void Update() {

    	if (RandomStart.endgame) {
			delta = Time.deltaTime;
	        timElapesed += Time.deltaTime;
	        if(timElapesed > (delta+delay))
	        	endGamePanel.SetActive (true);
	    }
    }
}
