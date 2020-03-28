using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class ModalPanel : MonoBehaviour {

    public Button witness1;
    public Button witness2;
    public Button cancel;
    public GameObject modalPanelObject;

    private static Sprite img;
    public List<Sprite> SpriteList;
    public int randomNumber;
    public static Sprite savedSprite1 = null;
    public static Sprite savedSprite2 = null;


    private static ModalPanel modalPanel;

    public static ModalPanel Instance () {
        if (!modalPanel) {
            modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
            if (!modalPanel)
                Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
        }

        return modalPanel;
    }


    void Start() {

        SpriteList.Add(Resources.Load<Sprite>("Witness/404"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/BUG"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/CIENTISTA"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/CIENTISTA DE DADOS"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/DISQUETE"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/ESTAGIARIO"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/LIVRO"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/GAMERS"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/HACKER"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/INTELIGENCIA ARTIFICIAL"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PC"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PENDRIVE DE 1TB"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PORTAL NOTÍCIAS"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PROFESSOR"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PROGRAMADOR DE JAVA"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/PYTHONHO"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/ROBOBY"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/VR PLAYER"));
        SpriteList.Add(Resources.Load<Sprite>("Witness/SUPORTE"));


        if(savedSprite1 == null && savedSprite2 == null ) {
            do {
                randomNumber = Random.Range(0, 12);
                savedSprite1 = SpriteList[randomNumber];
                randomNumber = Random.Range(0, 12);
                savedSprite2 = SpriteList[randomNumber];
            } while (savedSprite1 == savedSprite2);
        }

        witness1.GetComponent<Image>().sprite = savedSprite1;
        witness2.GetComponent<Image>().sprite = savedSprite2;        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
            ClosePanel();
    }

    public static Sprite GetImg() {
        return img;
    }

    public void Choice (UnityAction witness1Event, UnityAction witness2Event, UnityAction cancelEvent) {
        modalPanelObject.SetActive (true);

        witness1.onClick.RemoveAllListeners();
        witness1.onClick.AddListener (ChangeImage1);
        witness1.onClick.AddListener (witness1Event);
        witness1.onClick.AddListener (ClosePanel);

        witness2.onClick.RemoveAllListeners();
        witness2.onClick.AddListener (ChangeImage2);
        witness2.onClick.AddListener (witness2Event);
        witness2.onClick.AddListener (ClosePanel);

        cancel.onClick.RemoveAllListeners();
        cancel.onClick.AddListener (cancelEvent);
        cancel.onClick.AddListener (ClosePanel);

        witness1.gameObject.SetActive (true);
        witness2.gameObject.SetActive (true);
        cancel.gameObject.SetActive (true);
    }

    void ClosePanel () {
        modalPanelObject.SetActive (false);
    }

    void ChangeImage1 () {
        img = witness1.GetComponent<Image>().sprite;
    }

    void ChangeImage2 () {
        img = witness2.GetComponent<Image>().sprite;
    }
}