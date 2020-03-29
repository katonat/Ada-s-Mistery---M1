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

	// QUESTION
	public GameObject question;

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
		setQuestion();
		
        next.onClick.RemoveAllListeners();
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

    public void closeButton() {
    	next.gameObject.SetActive (false);
    }

    public void activatePreviousButton() {
    	previous.gameObject.SetActive (true);
    }


    public void setQuestion() {
    	if (RandomStart.GetMisteryNumber() == 1)
    		question.GetComponent<Text>().text = "Qual é a linguagem de programação que está sendo utitilizada com tecnologias atuais, como IA?";
    	else if(RandomStart.GetMisteryNumber() == 2)
    		question.GetComponent<Text>().text = "Qual é o comando de repetição que Ada está procurando?";
    }




}
