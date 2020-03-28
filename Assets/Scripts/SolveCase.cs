using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolveCase : MonoBehaviour {

    public GameObject solveCasePanel;
    private int misteryNumber;
    private List<string> options;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject optionRight;


	void Start() {

		options = new List<string>();

		misteryNumber = RandomStart.GetMisteryNumber();

        if (RandomStart.notesCounter >= 1)
            solveCasePanel.SetActive (true);
        

        if (misteryNumber == 1) {
        	options.Add("Java");
        	options.Add("Html");
        	options.Add("Assembly");
        	options.Add("Python");
        	options.Add("C");
        } else if (misteryNumber == 2) {
        	options.Add("For");
        	options.Add("Try - Catch");
        	options.Add("While");
        	options.Add("Do - While");
        	options.Add("Switch");
        }

        option1.GetComponent<Text>().text = options[0];
        option2.GetComponent<Text>().text = options[1];
        option3.GetComponent<Text>().text = options[2];
        optionRight.GetComponent<Text>().text = options[3];
        option4.GetComponent<Text>().text = options[4];



	}

}
