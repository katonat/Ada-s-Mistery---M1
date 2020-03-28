using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ChangeImage : MonoBehaviour {
       
    public Sprite imgSprite;

    void Start() {
        if (imgSprite = ModalPanel.GetImg()) {
	    	this.gameObject.GetComponent<Image>().sprite = imgSprite;
	    	GameObject.Find("WitnessName").GetComponent<Text>().text = imgSprite.name;
        } 
    }


}
