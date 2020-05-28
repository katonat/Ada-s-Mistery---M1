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
    public static List<string> phpOptions;

    public static int pythonCont = 0;
    public static int javaCont = 0;
    public static int cCont = 0;
	public static int phpCont = 0;

    public static int notesCounter = 0;

    // ANNOTATIONS LISTS
    public static List<string> pythonAnnotations;
    public static List<string> javaAnnotations;
    public static List<string> cAnnotations;
    public static List<string> phpAnnotations;

    public static List<string> playerAnnotations;


    public RandomStart() {

        pythonOptions = new List<string>();
        javaOptions = new List<string>();
        cOptions = new List<string>();
        phpOptions = new List<string>();        

        pythonAnnotations = new List<string>();
        javaAnnotations = new List<string>();
        cAnnotations = new List<string>();
        phpAnnotations = new List<string>();

        playerAnnotations = new List<string>() {"", "", "", "", ""};
    }

    public int randomMistery() {
        total = 4;
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

                // PHP
                phpOptions.Add("PHP provavelmente não é a melhor linguagem para criação de aplicações desktop com interfaces gráficas.");
                phpOptions.Add("Assim como Python, PHP possui tipagem dinâmica e é uma linguagem interpretada.");
                phpOptions.Add("Dizem por aí que PHP pode ser embutida dentro do HTML.");
                phpOptions.Add("Fiquei sabendo que PHP é bastante usado em aplicações WEB.");                

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

                // PHP
                phpAnnotations.Add("PHP não é a melhor linguagem para aplicações desktop com interface gráfica");
                phpAnnotations.Add("PHP é interpretada e tem tipagem dinâmica");
                phpAnnotations.Add("PHP pode ser embutida dentro do HTML");
                phpAnnotations.Add("PHP é muito usado em aplicações web");   

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

                // PHP
                phpOptions.Add("Só acho que se você está procurando uma estrutura que execute pelo menos uma vez, não deveria optar pelo WHILE.");
                phpOptions.Add("O loop DO-WHILE tem comportamento parecido com o WHILE, com a diferença que a validação da condição é feita no final de cada iteração.");
                phpOptions.Add("O PHP possui quatro estruturas de repetição: FOR, FOREACH, WHILE e DO-WHILE.");
                phpOptions.Add("Tudo o que sei é que estruturas de repetição permitem executar trechos de código mais de uma vez de acordo com uma condição."); 

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

                // PHP
                phpAnnotations.Add("WHILE pode não executar nenhuma vez");
                phpAnnotations.Add("DO-WHILE valida a condição no final da iteração");
                phpAnnotations.Add("PHP possui FOR, FOREACH, WHILE e DO-WHILE");
                phpAnnotations.Add("Estruturas de repetição permitem executar um código mais de uma vez");

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

                // PHP
                phpOptions.Add("Em POO, encapsulamento significa separar o programa em partes, o mais isolado possível.");
                phpOptions.Add("O termo polimorfismo é originário do grego e significa \"muitas formas\" (poli = muitas, morphos = formas).");
                phpOptions.Add("Ouvi dizer que a partir da versão 5 do PHP ficou mais simples implementar encapsulamento de métodos e propriedades.");
                phpOptions.Add("Os paradigmas de PHP são procedural, reflexão, orientação a objetos, funcional."); 
                
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

                // PHP
                phpAnnotations.Add("Encapsulamento: isolar o programa em partes");
                phpAnnotations.Add("Polimorfismo: muitas formas");
                phpAnnotations.Add("PHP 5: melhorou o encapsulamento");
                phpAnnotations.Add("Paradigmas de PHP: procedural, reflexão, orientação a objetos, funcional");

                break;

            	case 4:
                Debug.Log("Mistery 4. Resp.: SWITCH-CASE");
                Debug.Log(win);
                						// TESTIMONIES
                // PYTHON 
                pythonOptions.Add("Apesar de ser opcional, o uso do BREAK em comando SWITCH-CASE pode ser decisivo para a sua correta execução.");
                pythonOptions.Add("Ouvi falar de uma estrutura que avalia cada CASO na busca pela igualdade da variável passada como parâmetro, você devia investigar mais sobre isso.");
                pythonOptions.Add("Em alguma situações você pode usar o IF-ELSE ou o SWITCH-CASE para resolver o mesmo problema.");
                pythonOptions.Add("Sobre estrutura condicional, posso dizer que determinado comando é executado se a condição for verdadeira.");

				// JAVA
                javaOptions.Add("Acredito que a estrutura que você procura busca somente valores iguais à variável fornecida.");
                javaOptions.Add("DEFAULT é uma palavra reservada que podemos utilizar no SWITCH-CASE para direcionar o programa no caso de ser digitado um valor inválido.");
                javaOptions.Add("Quando estruturamos um menu de opções, geralmente temos várias opções de escolha que podem ser numeradas (caso 1, caso 2, caso 3 , etc).");
                javaOptions.Add("Em Java, utilizamos o operador == para comprar se um valor é igual ao outro.");

				// C
                cOptions.Add("O comando SWITCH-CASE compara uma mesma variável com vários casos.");
                cOptions.Add("Em switch-case, se o caso selecionado não possuir o BREAK no final do comando, ele entra na condição abaixo dele.");
                cOptions.Add("Pelo que ouvi falar, a estrutura que você procura é muito utilizada para programar menus em C.");
                cOptions.Add("Existem vários operadores de comparação quando falamos de estruturas condicionais. Temos igualdade, diferença, maior que, menor que, etc.");

                // PHP
                phpOptions.Add("Tenho a impressão que a estrutura que você procura é utilizada quando queremos comparar a mesma variável ou expressão com várias opções.");
                phpOptions.Add("Para expressões condicionais mais complexas, como comparar se um valor é maior (>) que o outros, usamos o IF-ELSE ao invés do SWITCH-CASE.");
                phpOptions.Add("Na maioria das linguagens de programação, a lógica das estruturas condicionais é muito parecida.");
                phpOptions.Add("Tudo que sei, é que você deveria procurar mais informações sobre estruturas que utilizam o operador DEFAULT."); 
                
                						// ANNOTATIONS
                // PYTHON
                pythonAnnotations.Add("O BREAK é um comando importante no SWITCH-CASE");
                pythonAnnotations.Add("Investigar sobre estrutura que avalia casos buscando pela igualdade");
                pythonAnnotations.Add("IF-ELSE e SWITCH-CASE podem ser usados com o mesmo propósito");
                pythonAnnotations.Add("O comando é executado se a condição for veradeira");

                // JAVA
                javaAnnotations.Add("Estrutura que busca valores iguais");
                javaAnnotations.Add("DEFAULT é usado no SWITCH-CASE para valores inválidos");
                javaAnnotations.Add("Estruturas de Menus: Caso 1, Caso 2, Caso 3");
                javaAnnotations.Add("== é um operador de igualdade");

                // C
                cAnnotations.Add("SWITCH-CASE compara uma variável a vários casos");
                cAnnotations.Add("O BREAK impede que o caso selecionado não entre na condição abaixo dele");
                cAnnotations.Add("Buscar estruturas de fazer Menus em C");
                cAnnotations.Add("Exemplos de operadores de comparação: igualdade, diferença, etc");

                // PHP
                phpAnnotations.Add("Procuro uma estrutura que compara uma variável com opções");
                phpAnnotations.Add("MAIOR QUE (>) usamos com IF-ELSE");
                phpAnnotations.Add("A lógica das estruturas condicionais é parecida em diferentes linguagens");
                phpAnnotations.Add("Procuro uma estrutura que utiliza o DEFAULT");

                break;
            default:
                Debug.Log("None");
                break;
        }

    }

}
