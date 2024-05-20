using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterNaming : MonoBehaviour
{

    // Calling masterOrder from MasterNaming script
    [SerializeField] private MasterNaming masterNaming;

    // Getting the GameObjects
    [SerializeField] public GameObject oneChar;
    [SerializeField] public GameObject twoChar;
    [SerializeField] public GameObject threeChar;
    [SerializeField] public GameObject fourChar;
    [SerializeField] public GameObject fiveChar;
    [SerializeField] public GameObject sixChar;
    [SerializeField] public GameObject sevenChar;
    [SerializeField] public GameObject eightChar;

    // Button Letter
    [SerializeField] private string thisValue;


    private void Update() {
        if(masterNaming.masterOrder <1){
            masterNaming.masterOrder = 1;
        }

        if(masterNaming.masterOrder >9){
            masterNaming.masterOrder = 9;
        }
    }

    public void LetterSelect() {
        if(masterNaming.masterOrder == 1) {
            oneChar.GetComponent<Text>().text = thisValue;
            oneChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 2) {
            twoChar.GetComponent<Text>().text = thisValue;
            twoChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 3) {
            threeChar.GetComponent<Text>().text = thisValue;
            threeChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 4) {
            fourChar.GetComponent<Text>().text = thisValue;
            fourChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 5) {
            fiveChar.GetComponent<Text>().text = thisValue;
            fiveChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 6) {
            sixChar.GetComponent<Text>().text = thisValue;
            sixChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 7) {
            sevenChar.GetComponent<Text>().text = thisValue;
            sevenChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        } else if (masterNaming.masterOrder == 8) {
            eightChar.GetComponent<Text>().text = thisValue;
            eightChar.GetComponent<NameCharInfo>().emptyValue = false;
            masterNaming.masterOrder++;
        }
    }
}
