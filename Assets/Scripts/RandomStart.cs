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
    public static bool win = false;
    public static bool endgame = false;

    // TESTIMONIES
    public static List<string> pythonOptions;
    public static List<string> javaOptions;
    public static List<string> cOptions;

    public static int pythonCont = 0;
    public static int javaCont = 0;
    public static int cCont = 0;

    public static int notesCounter = 0;

    // ANNOTATIONS LISTS
    public static List<string> pythonAnnotations;
    public static List<string> javaAnnotations;
    public static List<string> cAnnotations;

    public static List<string> playerAnnotations;


    public RandomStart() {
        pythonOptions = new List<string>();
        javaOptions = new List<string>();
        cOptions = new List<string>();

        pythonAnnotations = new List<string>();
        javaAnnotations = new List<string>();
        cAnnotations = new List<string>();

        playerAnnotations = new List<string>() {"", "", "", "", ""};
    }

    public int randomMistery() {
        total = 3;
        misteryNumber = Random.Range(1, total+1);
        return misteryNumber;
    }

    public static int GetMisteryNumber() {
        return misteryNumber;
    }


    public void Start() {
        win = false;
        endgame = false;
        notesCounter = 0;
        randomNumber = randomMistery();

        switch(randomNumber) {
            case 1:
                Debug.Log("Mistery 1. Resp.: PYTHON");
                Debug.Log(win);
                						// TESTIMONIES
                // PYTHON
                pythonOptions.Add("Python é considerada uma linguagem de alto nível, quer dizer que sua escrita se aproxima mais a linguagem humana.");
                pythonOptions.Add("Em Python, não é necessário declarar as variáveis explicitamente, quer dizer que tem tipagem dinâmica.");
                pythonOptions.Add("Alguns dizem que Python se trata de uma linguagem minimalista.");
                pythonOptions.Add("Uma fonte confiável me disse que a linguagem que você procura tem sintaxe simples e de fácil aprendizado.");

                // JAVA
                javaOptions.Add("Ouvi dizer que essa linguagem que você procura é interpretada.");
                javaOptions.Add("Java possui suporte para Programação voltada a Orientação de Objetos.");
                javaOptions.Add("A implementação de Inteligência Artificial utiliza uma interface de manuseio simples e amigável.");
                javaOptions.Add("A linguagem que você procura possui uma escrita simples.");

                // C
                cOptions.Add("Em C, como na maioria das linguagens, as variáveis devem ser declaradas no início do programa.");
                cOptions.Add("Comparada com outras linguagens mais modernas, alguns dizem que C é mais próxima às linguagens de baixo nível.");
                cOptions.Add("C é uma linguagem compilada e não interpretada.");
                cOptions.Add("Em C, a seguinte linha de comando exibe na tela a frase \"Olá Mundo\":printf(\"Olá Mundo\");");

                						// ANNOTATIONS
                // PYTHON 
                pythonAnnotations.Add("Python é uma linguagem de alto nível");
                pythonAnnotations.Add("Python possui tipagem dinâmica");
                pythonAnnotations.Add("Python é uma linguagem minimalista");
                pythonAnnotations.Add("Procuro uma linguagem de fácil aprendizado");

                // JAVA ANNOTATIONS
                javaAnnotations.Add("Procuro uma linguagem interpretada");
                javaAnnotations.Add("Java é Orientado a Objetos");
                javaAnnotations.Add("IA utiliza uma interface amigável");
                javaAnnotations.Add("Procuro uma linguagem com escrita simples");

                // C
                cAnnotations.Add("É necessário declarar as variáveis em C");
                cAnnotations.Add("C é mais próxima de linguagens de baixo nível");
                cAnnotations.Add("C é compilada e não interpretada");
                cAnnotations.Add("Em C o printf exibe algo na tela");

                break;
            case 2:
                Debug.Log("Mistery 2. Resp.: DO-WHILE");
                Debug.Log(win);
                							// TESTIMONIES
                // PYTHON
                pythonOptions.Add("Python é uma linguagem interpretada, ou seja, a tradução dos comandos é feita em tempo de execução.");
                pythonOptions.Add("Em computação, costumamos considerar o 0 como 'falso' e o 1 como 'verdadeiro'.");
                pythonOptions.Add("Sobre a sentença que você procura, ouvi dizer que mesmo que a condição seja falsa, o comando é executado uma vez.");
                pythonOptions.Add("A única coisa que posso fazer é dar um exemplo do comando FOR em Python:\n\"for nome in nomes:\"");

                // JAVA
                javaOptions.Add("Quando não se sabe quantas vezes um comando deve ser repetido, utilizamos o comando WHILE.");
                javaOptions.Add("O comando DO-WHILE garante que pelo menos uma vez o comando seja executado.");
                javaOptions.Add("Só sei que ao utilizar o WHILE, pode ser que o comando nunca seja executado.");
                javaOptions.Add("Se eu fosse você pesquisaria mais sobre esse tipo de estrutura:\nFaça {(comando)} Enquanto (condição);");

                // C
                cOptions.Add("Em certos casos, ao invés de incrementar, podemos decrementar a variável de controle e construir um laço com contagem decrescente.");
                cOptions.Add("Um exemplo de laço de repetição em C pode ser: for(i = 0; i < 5; i++)");
                cOptions.Add("As estruturas de repetição, executam a repetição de um conjunto de instruções enquanto uma determinada condição é verdadeira.");
                cOptions.Add("Ouvi sobre um comando de repetição que pode te ajudar. Primeiro se executa o comando e depois é analisada a condição.");

                							// ANNOTATIONS
                // PYTHON
                pythonAnnotations.Add("Python é uma linguagem interpretada");
                pythonAnnotations.Add("1 = true\n0 = false");
                pythonAnnotations.Add("Executa o comando uma vez se a condição for falsa");
                pythonAnnotations.Add("For em Python:\nfor nome in nomes:");

                // JAVA
                javaAnnotations.Add("A quantidade de repetições é incerta com WHILE");
                javaAnnotations.Add("DO-WHILE executa o comando pelo menos uma vez");
                javaAnnotations.Add("WHILE: o comando pode nunca ser executado");
                javaAnnotations.Add("Pesquisar:\nFaça {(comando)} Enquanto (condição);");

                // C
                cAnnotations.Add("Incrementar: contador crescente. Decrementar: contador decrescente");
                cAnnotations.Add("Comando for em C: for(i = 0; i < 5; i++)");
                cAnnotations.Add("Se a condição for verdadeira a instrução é executada");
                cAnnotations.Add("Procurar por comando que executa primeiro e analisa depois");

                break;
            case 3:
                Debug.Log("Mistery 3. Resp.: POLIMORFISMO");
                Debug.Log(win);
                						// TESTIMONIES
                // PYTHON 
                pythonOptions.Add("Ouvi dizer que em programação, Herança faz com que determinada classe herde características de outra classe.");
                pythonOptions.Add("Python é uma linguagem multiparadigma.");
                pythonOptions.Add("Ouvi rumores sobre métodos de classes distintas que podem ter o mesmo nome, talvez você deva procurar saber mais sobre isso.");
                pythonOptions.Add("Se você está procurando por mutação, deveria procurar por características que mudam de forma.");

				// JAVA
                javaOptions.Add("O Polimorfismo facilita na reutilização de códigos.");
                javaOptions.Add("Fiquei sabendo que os quatro pilares do paradigma que você está investigando são: ABSTRAÇÃO, POLIMORFISMO, HERANÇA E ENCAPSULAMENTO.");
                javaOptions.Add("Java é considerada uma linguagem Orientada a Objetos.");
                javaOptions.Add("Sobre isso, sei que paradigmas de programação podem definir a forma de escrever um código de programação.");

				// C
                cOptions.Add("Dizem por aí que o Encapsulamento em POO serve para controlar o acesso aos atributos e métodos de uma classe.");
                cOptions.Add("Tudo que sei é que o Polimorfismo mostra como um método pode assumir formas diferentes das quais foram implementadas inicialmente.");
                cOptions.Add("Fiquei sabendo que Herança e Polimorfismo estão relacionados.");
                cOptions.Add("A programação estruturada tem ênfase em sequência, decisão e iteração.");

                						// ANNOTATIONS
                // PYTHON
                pythonAnnotations.Add("Herança: uma classe herda características da outra");
                pythonAnnotations.Add("Python é multiparadigma");
                pythonAnnotations.Add("Classes com o mesmo nome que fazem coisas diferentes");
                pythonAnnotations.Add("Procurar sobre mudança na forma");

                // JAVA
                javaAnnotations.Add("Polimorfismo facilita na reutilização de códigos");
                javaAnnotations.Add("POO: Abstração, Polimorfismo, Herança e Encapsulamento");
                javaAnnotations.Add("Java é Orientada a Objetos");
                javaAnnotations.Add("Paradigmas de Programação são metodolodias de linguagens");

                // C
                cAnnotations.Add("Encapsulamento controla o acesso a uma classe");
                cAnnotations.Add("Polimorfismo: um método assume formas diferentes");
                cAnnotations.Add("Herança e Polimorfismo estão relacionados");
                cAnnotations.Add("Programação estruturada: sequência, decisão, iteração");

                break;
            default:
                Debug.Log("None");
                break;
        }

    }

}
