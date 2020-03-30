using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

	public GameObject changeText;
	public int misteryNumber;
	public int total;
	public int randomNumber;
	public string world;

    void Start() {

    	total = 2;
        randomNumber = Random.Range(1, total+1);
        misteryNumber = RandomStart.GetMisteryNumber();

    	if (world == "Python") {
    		if (randomNumber == 1)
    			changeText.GetComponent<Text>().text = "Python foi criado por Guido van Rossum em 1991.\nÉ forte, funcional e de tipagem dinâmica, além disso, Python suporta múltiplos paradigmas de programação. ";

    		else
    			changeText.GetComponent<Text>().text = "Python, possui tipagem dinâmica e uma de suas principais características é permitir a fácil leitura do código e exigir poucas linhas de código se comparado ao mesmo programa em outras linguagens.";

    	} else if (world == "Java") {
    		if (randomNumber == 1)
    			changeText.GetComponent<Text>().text = "O paradigma de programação da linguagem JAVA baseia-se no conceito de Programação Orientada a Objetos, lembre-se desse conceito para resolver os próximos mistérios dessa linguagem.";
    		else
    			changeText.GetComponent<Text>().text = "Java é uma linguagem de programação e plataforma computacional lançada pela primeira vez pela Sun Microsystems em 1995.";

    	} else {
    		changeText.GetComponent<Text>().text = "None";
    	}
    }
}
