using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdasLine : MonoBehaviour {

	public GameObject changeText;
    public Button continuButton;
    public Image arrow;
    private int mistery;
    public Button map;
    private static string text;

    void Start() {
    	map.interactable = false;
    }

    void Update() {
        mistery = RandomStart.GetMisteryNumber();
        continuButton.onClick.RemoveAllListeners();
        continuButton.onClick.AddListener (textChange);
        continuButton.onClick.AddListener (setActive);
        continuButton.onClick.AddListener(closeButton);
    }

    public static string getText() {
    	return text;
    }

    public void textChange() {
        if (mistery == 1)
        	text = "Há boatos sobre uma LINGUAGEM DE PROGRAMAÇÃO que está sendo muito utilizada com outras tecnologias atuais. Programadores comentaram que isso pode ter a ver com sua sintaxe.";
        else if (mistery == 2)
        	text = "Uma LINHA DE CÓDIGO desconhecida foi encontrada e sua origem precisa ser descoberta. Testemunhas disseram que podia se tratar de uma repetição de comandos.";
    	
    	changeText.GetComponent<Text>().text = text;
    }

    public void closeButton() {
    	continuButton.gameObject.SetActive (false);
    }

    public void setActive() {
    	arrow.gameObject.SetActive (true);
    	map.interactable = true;
    }


}
