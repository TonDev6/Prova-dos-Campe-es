using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharNameButtons : MonoBehaviour
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

    // Getting the UI of Character's name
    [SerializeField] private TextMeshProUGUI charName;

    // Next Scene
    private string startGame = "GameScreen";


    private void Update() {
        if(masterNaming.masterOrder <1){
            masterNaming.masterOrder = 1;
        }

        if(masterNaming.masterOrder >9){
            masterNaming.masterOrder = 9;
        }
    }

    public void OKButton() {

        if(oneChar.GetComponent<NameCharInfo>().emptyValue == true){
            oneChar.GetComponent<Text>().text = "";
        }
        if(twoChar.GetComponent<NameCharInfo>().emptyValue == true){
            twoChar.GetComponent<Text>().text = "";
        }
        if(threeChar.GetComponent<NameCharInfo>().emptyValue == true){
            threeChar.GetComponent<Text>().text = "";
        }
        if(fourChar.GetComponent<NameCharInfo>().emptyValue == true){
            fourChar.GetComponent<Text>().text = "";
        }
        if(fiveChar.GetComponent<NameCharInfo>().emptyValue == true){
            fiveChar.GetComponent<Text>().text = "";
        }
        if(sixChar.GetComponent<NameCharInfo>().emptyValue == true){
            sixChar.GetComponent<Text>().text = "";
        }
        if(sevenChar.GetComponent<NameCharInfo>().emptyValue == true){
            sevenChar.GetComponent<Text>().text = "";
        }
        if(eightChar.GetComponent<NameCharInfo>().emptyValue == true) {
            eightChar.GetComponent<Text>().text = "";
        }


        if(oneChar.GetComponent<NameCharInfo>().emptyValue == true && twoChar.GetComponent<NameCharInfo>().emptyValue == true && threeChar.GetComponent<NameCharInfo>().emptyValue == true && fourChar.GetComponent<NameCharInfo>().emptyValue == true && fiveChar.GetComponent<NameCharInfo>().emptyValue == true && sixChar.GetComponent<NameCharInfo>().emptyValue == true && sevenChar.GetComponent<NameCharInfo>().emptyValue == true && eightChar.GetComponent<NameCharInfo>().emptyValue == true) {
            oneChar.GetComponent<Text>().text = "Z";
            twoChar.GetComponent<Text>().text = "a";
            threeChar.GetComponent<Text>().text = "g";
            fourChar.GetComponent<Text>().text = "r";
            fiveChar.GetComponent<Text>().text = "e";
            sixChar.GetComponent<Text>().text = "u";
            sevenChar.GetComponent<Text>().text = "s";
            eightChar.GetComponent<Text>().text = "";
        }


        charName.text = oneChar.GetComponent<Text>().text + twoChar.GetComponent<Text>().text + threeChar.GetComponent<Text>().text + fourChar.GetComponent<Text>().text + fiveChar.GetComponent<Text>().text + sixChar.GetComponent<Text>().text + sevenChar.GetComponent<Text>().text + eightChar.GetComponent<Text>().text;

        SceneManager.LoadScene(startGame);
    }

    public void BackButton() {
        if(masterNaming.masterOrder == 2) {
            masterNaming.masterOrder--;
            oneChar.GetComponent<Text>().text = "_";
            oneChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 3) {
            masterNaming.masterOrder--;
            twoChar.GetComponent<Text>().text = "_";
            twoChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 4) {
            masterNaming.masterOrder--;
            threeChar.GetComponent<Text>().text = "_";
            threeChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 5) {
            masterNaming.masterOrder--;
            fourChar.GetComponent<Text>().text = "_";
            fourChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 6) {
            masterNaming.masterOrder--;
            fiveChar.GetComponent<Text>().text = "_";
            fiveChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 7) {
            masterNaming.masterOrder--;
            sixChar.GetComponent<Text>().text = "_";
            sixChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 8) {
            masterNaming.masterOrder--;
            sevenChar.GetComponent<Text>().text = "_";
            sevenChar.GetComponent<NameCharInfo>().emptyValue = true;
        } else if (masterNaming.masterOrder == 9) {
            masterNaming.masterOrder--;
            eightChar.GetComponent<Text>().text = "_";
            eightChar.GetComponent<NameCharInfo>().emptyValue = true;
        }
    }
}
