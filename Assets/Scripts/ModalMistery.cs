using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalMistery : MonoBehaviour {

	public GameObject textToChange;
    public GameObject modalMisteryPanel;

    private static ModalMistery modalMistery;

    public static ModalMistery Instance () {
        if (!modalMistery) {
            modalMistery = FindObjectOfType(typeof (ModalMistery)) as ModalMistery;
            if (!modalMistery)
                Debug.LogError ("There needs to be one active ModalMistery script on a GameObject in your scene.");
        }
        return modalMistery;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(0))
            ClosePanel();
    }

    public void mistery() {
    	modalMisteryPanel.SetActive (true);
    	textToChange.GetComponent<Text>().text = AdasLine.getText();
    }


    void ClosePanel () {
        modalMisteryPanel.SetActive (false);
    }
}
