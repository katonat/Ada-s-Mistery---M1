using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolveCase : MonoBehaviour {

    public GameObject solveCasePanel;
    private int misteryNumber;

    // BUTTONS TEXTS
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject option5;

    // SOLVE CASE OPTIONS
    private int random = 0;
    private int counter = 0;
    private List<string> misteryChoices;
    private List<string> options;

	void Start() {

		options = new List<string>();
        misteryChoices = new List<string>() {"", "", "", "", ""};

		misteryNumber = RandomStart.GetMisteryNumber();

        if (RandomStart.notesCounter == 5 || (RandomStart.pythonOptions.Count == 0 && RandomStart.javaOptions.Count == 0))
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
        } else if (misteryNumber == 3) {
            options.Add("Polimorfismo");
            options.Add("Encapsulamento");
            options.Add("Herança");
            options.Add("Abstração");
            options.Add("Interface");
        }

        while (counter < 5) {
            random = Random.Range(0, 5);
            if (misteryChoices[random] == "") 
                misteryChoices[random] = options[counter++];
        }

        option1.GetComponent<Text>().text = misteryChoices[0];
        option2.GetComponent<Text>().text = misteryChoices[1];
        option3.GetComponent<Text>().text = misteryChoices[2];
        option4.GetComponent<Text>().text = misteryChoices[3];
        option5.GetComponent<Text>().text = misteryChoices[4];

	}
}
