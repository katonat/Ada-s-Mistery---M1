using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeNotes : MonoBehaviour {


    public void takeNote(string world) {

    	if (world == "Java")
	        saveJavaAnnotation();
	    else if (world == "Python")
	        savePythonAnnotation();
    }


    public void savePythonAnnotation() {
        RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.pythonAnnotations[RandomStart.pythonOptions.Count]);
        RandomStart.pythonAnnotations.RemoveAt(RandomStart.pythonOptions.Count);
        RandomStart.notesCounter++;
        
    }

    public void saveJavaAnnotation() {
        RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.javaAnnotations[RandomStart.javaOptions.Count]);
        RandomStart.javaAnnotations.RemoveAt(RandomStart.javaOptions.Count);
        RandomStart.notesCounter++;
        
    }

    public void closeTakeNoteButton (string buttonName) {
        // GameObject.Find(buttonName).interactable = false;
        GameObject.Find(buttonName).GetComponent<Button>().interactable = false;
    }

    public void changeNoteText (string noteName) {
        GameObject.Find(noteName).GetComponent<Text>().text = "ANOTADO";
    }
 
}
