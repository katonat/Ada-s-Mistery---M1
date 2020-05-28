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
        else if (world == "C")
            saveCAnnotation();
        else if (world == "PHP")
            savePhpAnnotation();
    }


    public void savePythonAnnotation() {
        if(RandomStart.pythonOptions.Count >= 0) {
            RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.pythonAnnotations[RandomStart.pythonOptions.Count]);
            RandomStart.pythonAnnotations.RemoveAt(RandomStart.pythonOptions.Count);
            RandomStart.notesCounter++;
        }
    }

    public void saveJavaAnnotation() {
        if (RandomStart.javaOptions.Count >= 0) {
            RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.javaAnnotations[RandomStart.javaOptions.Count]);
            RandomStart.javaAnnotations.RemoveAt(RandomStart.javaOptions.Count);
            RandomStart.notesCounter++;
        }
    }

    public void saveCAnnotation() {
        if (RandomStart.cOptions.Count >= 0) {
            RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.cAnnotations[RandomStart.cOptions.Count]);
            RandomStart.cAnnotations.RemoveAt(RandomStart.cOptions.Count);
            RandomStart.notesCounter++;
        }
    }

    public void savePhpAnnotation() {
        if (RandomStart.phpOptions.Count >= 0) {
            RandomStart.playerAnnotations.Insert(RandomStart.notesCounter, RandomStart.phpAnnotations[RandomStart.phpOptions.Count]);
            RandomStart.phpAnnotations.RemoveAt(RandomStart.phpOptions.Count);
            RandomStart.notesCounter++;
        }
    }

    public void closeTakeNoteButton (string buttonName) {
        GameObject.Find(buttonName).GetComponent<Button>().interactable = false;
    }

    public void changeNoteText (string noteName) {
        GameObject.Find(noteName).GetComponent<Text>().text = "ANOTADO";
    }
 
}
