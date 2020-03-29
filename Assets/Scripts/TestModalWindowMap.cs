using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestModalWindowMap : MonoBehaviour {
    private ModalMap modalMap;
    // private UnityAction javaWorldAction;
    // private UnityAction pythonWorld2Action;

    void Awake () {
        modalMap = ModalMap.Instance ();
        // javaWorldAction = new UnityAction (changeSceneJavaWorld);
        // pythonWorld2Action = new UnityAction (changeScenePythonWorld);
    }

    public void ChooseWorld () {
        modalMap.Choice ();
    }


    // void changeScenePythonWorld () {
    //     SceneManager.LoadScene("PythonWorld");
    // }

    // void changeSceneJavaWorld () {
    //     SceneManager.LoadScene("JavaWorld");
    // }

}