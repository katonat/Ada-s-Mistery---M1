﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ModalMap : MonoBehaviour {

    public Button javaWorld;
    public Button pythonWorld;
    public Button cWorld;
    public Button phpWorld;

    public Button cancel;
    public GameObject modalPanelObject;
    private static ModalMap modalPanel;

    public static ModalMap Instance () {
        if (!modalPanel) {
            modalPanel = FindObjectOfType(typeof (ModalMap)) as ModalMap;
            if (!modalPanel)
                Debug.LogError ("There needs to be one active ModalMap script on a GameObject in your scene.");
        }

        return modalPanel;
    }

    void Update() {
    	if (Input.GetKeyDown(KeyCode.Escape))
    		ClosePanel();
    }

    public void Choice () {
        modalPanelObject.SetActive (true);

        javaWorld.onClick.RemoveAllListeners();
        javaWorld.onClick.AddListener (changeSceneJavaWorld);

        pythonWorld.onClick.RemoveAllListeners();
        pythonWorld.onClick.AddListener (changeScenePythonWorld);

        cWorld.onClick.RemoveAllListeners();
        cWorld.onClick.AddListener (changeSceneCWorld);

        phpWorld.onClick.RemoveAllListeners();
        phpWorld.onClick.AddListener (changeScenePhpWorld);

        cancel.onClick.RemoveAllListeners();
        cancel.onClick.AddListener (ClosePanel);


        javaWorld.gameObject.SetActive (true);
        pythonWorld.gameObject.SetActive (true);
        cWorld.gameObject.SetActive (true);

        cancel.gameObject.SetActive (true);
    }

    void ClosePanel () {
        modalPanelObject.SetActive (false);
    }

    void changeScenePythonWorld () {
        SceneManager.LoadScene("PythonWorld");
    }

    void changeSceneJavaWorld () {
        SceneManager.LoadScene("JavaWorld");
    }

    void changeScenePhpWorld () {
        SceneManager.LoadScene("PhpWorld");
    }

    void changeSceneCWorld () {
        SceneManager.LoadScene("CWorld");
    }

}