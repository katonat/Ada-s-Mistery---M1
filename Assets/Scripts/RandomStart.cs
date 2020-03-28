using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomStart : MonoBehaviour {

    // MISTERIES
	public int total;
	public int randomNumber;
    private static int misteryNumber;

    // TESTIMONIES
    public static List<string> pythonOptions;
    public static List<string> javaOptions;
    public static int pythonCont = 0;
    public static int javaCont = 0;
    public static int notesCounter = 0;

    // ANNOTATIONS LISTS
    public static List<string> pythonAnnotations;
    public static List<string> javaAnnotations;
    public static List<string> playerAnnotations;


    public RandomStart() {
        pythonOptions = new List<string>();
        javaOptions = new List<string>();
        pythonAnnotations = new List<string>();
        javaAnnotations = new List<string>();
        playerAnnotations = new List<string>() {"", "", "", "", ""};
    }

    public int randomMistery() {
        total = 2;
        misteryNumber = Random.Range(1, total+1);
        return misteryNumber;
    }

    public static int GetMisteryNumber() {
        return misteryNumber;
    }


    public void Start() {
        randomNumber = randomMistery();

        switch(randomNumber) {
            case 1:
                Debug.Log("Mistery 1. Resp.: PYTHON");

                // PYTHON TESTIMONIES
                pythonOptions.Add("Python é considerada uma linguagem de alto nível, quer dizer que sua escrita se aproxima mais a linguagem humana.");
                pythonOptions.Add("Em Python, não é necessário declarar as variáveis explicitamente, quer dizer que tem tipagem dinâmica.");
                pythonOptions.Add("Alguns dizem que Python se trata de uma linguagem minimalista.");
                pythonOptions.Add("Uma fonte confiável me disse que a linguagem que você procura tem sintaxe simples e de fácil aprendizado.");

                // JAVA TESTIMONIES
                javaOptions.Add("Ouvi dizer que essa linguagem que você procura é interpretada.");
                javaOptions.Add("Java possui suporte para Programação voltada a Orientação de Objetos.");
                javaOptions.Add("A implementação de Inteligência Artificial utiliza uma interface de manuseio simples e amigável.");
                javaOptions.Add("A linguagem que você procura possui uma escrita simples.");

                // PYTHON ANNOTATIONS
                pythonAnnotations.Add("Python é uma linguagem de alto nível");
                pythonAnnotations.Add("Python possui tipagem dinâmica");
                pythonAnnotations.Add("Python é uma linguagem minimalista");
                pythonAnnotations.Add("Procuro uma linguagem de fácil aprendizado");

                // JAVA ANNOTATIONS
                javaAnnotations.Add("Procuro uma linguagem interpretada");
                javaAnnotations.Add("Java é Orientado a Objetos");
                javaAnnotations.Add("IA utiliza uma interface amigável");
                javaAnnotations.Add("Procuro uma linguagem com escrita simples");

                break;
            case 2:
                Debug.Log("Mistery 2. Resp.: DO-WHILE");

                // PYTHON TESTIMONIES
                pythonOptions.Add("Python é uma linguagem interpretada, ou seja, a tradução dos comandos é feita em tempo de execução.");
                pythonOptions.Add("Python é considerada uma linguagem multiplataforma.");
                pythonOptions.Add("O comando DO-WHILE garante que pelo menos uma vez o comando seja executado.");
                pythonOptions.Add("A única coisa que posso fazer é dar um exemplo do comando FOR em Python:\n\"for nome in nomes:\"");

                // JAVA TESTIMONIES
                javaOptions.Add("Quando não se sabe quantas vezes um comando deve ser repetido, utilizamos o comando WHILE.");
                javaOptions.Add("Se eu fosse você pesquisaria mais sobre esse tipo de estrutura: \nFaça { (comando) } Enquanto (condição);");
                javaOptions.Add("Só sei que ao utilizar o WHILE, pode ser que o comando nunca seja executado.");
                javaOptions.Add("Projetos em JAVA costumam utilizar as classes dentro de pacotes.");


                                // PYTHON ANNOTATIONS
                pythonAnnotations.Add("Python é uma linguagem interpretada");
                pythonAnnotations.Add("Python é multiplataforma");
                pythonAnnotations.Add("DO-WHILE executa o comando pelo menos uma vez");
                pythonAnnotations.Add("For em Python:\nfor nome in nomes:");

                // JAVA ANNOTATIONS
                javaAnnotations.Add("A quantidade de repetições é incerta com WHILE");
                javaAnnotations.Add("Pesquisar:\nFaça { (comando) } Enquanto (condição);");
                javaAnnotations.Add("WHILE: o comando pode nunca ser executado");
                javaAnnotations.Add("Java utiliza pacotes");

                break;
            default:
                Debug.Log("None");
                break;
        }

    }

}
