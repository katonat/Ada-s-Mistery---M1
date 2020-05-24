using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestModalWindow : MonoBehaviour {
    private ModalPanel modalPanel;
    private UnityAction myWitness1Action;
    private UnityAction myWitness2Action;
    private UnityAction cancelAction;
    public string world;

    void Awake () {
        modalPanel = ModalPanel.Instance ();
        myWitness1Action = new UnityAction (Witness1Dialog);
        myWitness2Action = new UnityAction (Witness2Dialog);
        cancelAction = new UnityAction (CancelDialog);

    }

    public void ChooseWitness () {
        modalPanel.Choice (Witness1Dialog, Witness2Dialog, CancelDialog);
    }

    void Witness1Dialog () {
        if (world == "Java")
            SceneManager.LoadScene("WitnessJava");
        else if (world == "Python")
            SceneManager.LoadScene("WitnessPython");
        else if (world == "C")
            SceneManager.LoadScene("WitnessC");
    }

    void Witness2Dialog () {
        if ( world == "Java")
            SceneManager.LoadScene("WitnessJava");
        else if (world == "Python")
            SceneManager.LoadScene("WitnessPython");   
        else if (world == "C")
            SceneManager.LoadScene("WitnessC");
    }

    void CancelDialog () {
    }

}