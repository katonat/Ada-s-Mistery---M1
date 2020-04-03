using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWinner : MonoBehaviour {

	private int misteryNumber;
	public GameObject caseSolved;
	public GameObject wrong;


	void Start() {
		misteryNumber = RandomStart.GetMisteryNumber();
		caseSolved = GameObject.Find("CaseSolved");
		wrong = GameObject.Find("Wrong");

		caseSolved.SetActive(false);
		wrong.SetActive(false);
	}

    void Update() {
        if (caseSolved.activeSelf) {
            RandomStart.win = true;
        }
    }


    public void checkWinOne() {

        if (misteryNumber == 1) {
            if (GameObject.Find("Text1").GetComponent<Text>().text == "Python") 
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
		
        } else if (misteryNumber == 2) {
            if (GameObject.Find("Text1").GetComponent<Text>().text == "Do - While")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        }
    }

    public void checkWinTwo() {

        if (misteryNumber == 1) {
            if (GameObject.Find("Text2").GetComponent<Text>().text == "Python")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        } else if (misteryNumber == 2) {
            if (GameObject.Find("Text2").GetComponent<Text>().text == "Do - While")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        }
    }    public void checkWinThree() {

        if (misteryNumber == 1) {
            if (GameObject.Find("Text3").GetComponent<Text>().text == "Python")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        } else if (misteryNumber == 2) {
            if (GameObject.Find("Text3").GetComponent<Text>().text == "Do - While")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        }
    }    public void checkWinFour() {

        if (misteryNumber == 1) {
            if (GameObject.Find("Text4").GetComponent<Text>().text == "Python")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        } else if (misteryNumber == 2) {
            if (GameObject.Find("Text4").GetComponent<Text>().text == "Do - While")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        }
    }    public void checkWinFive() {

        if (misteryNumber == 1) {
            if (GameObject.Find("Text5").GetComponent<Text>().text == "Python")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        } else if (misteryNumber == 2) {
            if (GameObject.Find("Text5").GetComponent<Text>().text == "Do - While")
                caseSolved.SetActive(true);
            else
				wrong.SetActive(true);
        }
    }
}
