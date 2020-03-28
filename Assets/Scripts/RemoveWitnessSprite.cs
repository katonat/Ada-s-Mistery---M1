using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWitnessSprite : MonoBehaviour {

    public void RemoveWitness() {
        ModalPanel.savedSprite1 = null;
        ModalPanel.savedSprite2 = null;

        RandomStart.pythonCont = 0;
        RandomStart.javaCont = 0;
    }

}
