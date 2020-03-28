using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNotepadWindow : MonoBehaviour {

	private ModalNotepad modalNotepad;

	void Awake() {
		modalNotepad = ModalNotepad.Instance();
	}

	public void showNotes() {
		modalNotepad.notes();
	}
    
}
