using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

	public GameObject changeText;
	public int total;
	public int randomNumber;
	public string world;

    void Start() {

    	total = 2;
        randomNumber = Random.Range(1, total+1);

    	if (world == "Python") {
    		if (randomNumber == 1)
    			changeText.GetComponent<Text>().text = "Python é forte, funcional e de tipagem dinâmica.\nAlém disso, Python suporta múltiplos paradigmas de programação. ";
    		else
    			changeText.GetComponent<Text>().text = "Python possui poucas linhas de código se comparado ao mesmo programa em outras linguagens. É considerada uma linguagem de fácil leitura.";

    	} else if (world == "Java") {
    		if (randomNumber == 1)
    			changeText.GetComponent<Text>().text = "O paradigma de programação da linguagem JAVA baseia-se no conceito de Programação Orientada a Objetos.";
    		else
    			changeText.GetComponent<Text>().text = "Java está atualmente entre as 3 linguagens mais populares do mundo.";

        } else if (world == "C") {
            if (randomNumber == 1)
                changeText.GetComponent<Text>().text = "C é uma linguagem de programação compilada de propósito geral, estruturada, imperativa e procedural.";
            else
                changeText.GetComponent<Text>().text = "C tem influenciado muitas outras linguagens de programação (por exemplo, a linguagem Java).";
        
        } else if (world == "PHP") {
            if (randomNumber == 1)
                changeText.GetComponent<Text>().text = "PHP é uma linguagem de script open source de uso geral, muito utilizada, e especialmente adequada para o desenvolvimento web.";
            else
                changeText.GetComponent<Text>().text = "PHP é uma linguagem de programação mundialmente conhecida e uma das mais utilizadas pela facilidade em aprendê-la e manuseá-la, além de ser compatível com quase todos os sistemas operacionais.";

    	} else {
    		changeText.GetComponent<Text>().text = "None";
    	}
    }
}
