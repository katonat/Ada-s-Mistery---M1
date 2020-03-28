using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class ModalNotepad : MonoBehaviour {

	public GameObject choicesPanel;
    public GameObject modalNotepadPanel;
	public Button next;
	public Button back;
	public Button previous;
	public int mistery;

	// ANNOTATIONS
	public GameObject annotation1;
	public GameObject annotation2;
	public GameObject annotation3;
	public GameObject annotation4;
	public GameObject annotation5;


	// SOLVE CASE CHOICES
	public Button RightAnswerButton;
	public Button bt1;
	public Button bt2;
	public Button bt3;
	public Button bt4;
	public Text RightAnswerText = null;
	public Text Text1 = null;
	public Text Text2 = null;
	public Text Text3 = null;
	public Text Text4 = null;


    private static ModalNotepad modalNotepad;

    public static ModalNotepad Instance () {
        if (!modalNotepad) {
            modalNotepad = FindObjectOfType(typeof (ModalNotepad)) as ModalNotepad;
            if (!modalNotepad)
                Debug.LogError ("There needs to be one active ModalNotepad script on a GameObject in your scene.");
        }
        return modalNotepad;
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
            ClosePanel();
    }

    void ClosePanel () {
        modalNotepadPanel.SetActive (false);
    }


    public void notes() {
    	modalNotepadPanel.SetActive (true);

		putAnnotations();    	

        next.onClick.RemoveAllListeners();
        next.onClick.AddListener (changeAnnotations);
        next.onClick.AddListener (closeButton);
        next.onClick.AddListener (activatePreviousButton);

        back.onClick.RemoveAllListeners();
        back.onClick.AddListener(ClosePanel);

    }

    public void putAnnotations() {
    	annotation1.GetComponent<Text>().text = RandomStart.playerAnnotations[0];
    	annotation2.GetComponent<Text>().text = RandomStart.playerAnnotations[1];
    	annotation3.GetComponent<Text>().text = RandomStart.playerAnnotations[2];
    	annotation4.GetComponent<Text>().text = RandomStart.playerAnnotations[3];
    	annotation5.GetComponent<Text>().text = RandomStart.playerAnnotations[4];
    }


    public void changeAnnotations() {
    	mistery = RandomStart.GetMisteryNumber();

    	choicesPanel.SetActive (true);

    	// SET TEXT OF THOSE BUTTONS
    	if (mistery == 1) {
			RightAnswerText.text = "PYTHON";
			Text1.text = "JAVA";
			Text2.text = "ASSEMBLY";
			Text3.text = "HTML";
			Text4.text = "C";
		} else if (mistery == 2) {
			RightAnswerText.text = "DO - WHILE";
			Text1.text = "FOR";
			Text2.text = "WHILE";
			Text3.text = "SWITCH";
			Text4.text = "TRY - CATCH";
		}
    }

    public void closeButton() {
    	next.gameObject.SetActive (false);
    }

    public void activatePreviousButton() {
    	previous.gameObject.SetActive (true);
    }







}
