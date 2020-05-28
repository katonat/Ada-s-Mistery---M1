using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class WitnessSpeech : MonoBehaviour {

	public GameObject changeText;
	public int misteryNumber;
	public int total;
	public int randomNumber;
	public string world;
    public Button takeNote;

    void Start() {

        if (RandomStart.notesCounter >= 5)
            takeNote.gameObject.SetActive(false);


        misteryNumber = RandomStart.GetMisteryNumber();

        if (world == "Python") {
            switchLines(RandomStart.pythonOptions, RandomStart.pythonCont);
            RandomStart.pythonCont++;
        } else if (world == "Java") {
            switchLines(RandomStart.javaOptions, RandomStart.javaCont);
            RandomStart.javaCont++;
        } else if (world == "C") {
            switchLines(RandomStart.cOptions, RandomStart.cCont);
            RandomStart.cCont++;
        } else if (world == "PHP") {
            switchLines(RandomStart.phpOptions, RandomStart.phpCont);
            RandomStart.phpCont++;  
        }
    }


    public void switchLines(List<string> testimoniesList, int counter) {
        string line;
        if (testimoniesList.Count > 0 && counter < 2) {
            line = testimoniesList[testimoniesList.Count-1];
            changeText.GetComponent<Text>().text = line;
            testimoniesList.RemoveAt(testimoniesList.Count-1);
        } else
            takeNote.gameObject.SetActive(false);
        
    }

}




