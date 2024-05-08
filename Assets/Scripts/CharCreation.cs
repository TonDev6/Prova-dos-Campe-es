using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CharCreation : MonoBehaviour
{


    [SerializeField] private GameObject firstEmptyCharacter;
    [SerializeField] private GameObject scndEmptyCharacter;
    [SerializeField] private GameObject thirdEmptyCharacter;
    [SerializeField] private GameObject fourEmptyCharacter;
    [SerializeField] private GameObject fiveEmptyCharacter;
    [SerializeField] private GameObject sixEmptyCharacter;
    [SerializeField] private GameObject sevenEmptyCharacter;
    [SerializeField] private GameObject eightEmptyCharacter;

    [SerializeField] private GameObject[] charMapDigts;


    [SerializeField] private PlayerLetters firstCharacter;
    [SerializeField] private PlayerLetters scndCharacter;
    [SerializeField] private PlayerLetters thirdCharacter;
    [SerializeField] private PlayerLetters fourCharacter;
    [SerializeField] private PlayerLetters fiveCharacter;
    [SerializeField] private PlayerLetters sixCharacter;
    [SerializeField] private PlayerLetters sevenCharacter;
    [SerializeField] private PlayerLetters eightCharacter;



    [SerializeField] private GameObject charName;

    private string[] emptyCharValue;
    private string charValue;

    private int digitSelected = 1;



    private void Awake() {
        charMapDigts = new GameObject[52];

        firstCharacter = firstEmptyCharacter.GetComponent<PlayerLetters>();
        scndCharacter = scndEmptyCharacter.GetComponent<PlayerLetters>();
        thirdCharacter = thirdEmptyCharacter.GetComponent<PlayerLetters>();
        fourCharacter = fourEmptyCharacter.GetComponent<PlayerLetters>();
        fiveCharacter = fiveEmptyCharacter.GetComponent<PlayerLetters>();
        sixCharacter = sixEmptyCharacter.GetComponent<PlayerLetters>();
        sevenCharacter = sevenEmptyCharacter.GetComponent<PlayerLetters>();
        eightCharacter = eightEmptyCharacter.GetComponent<PlayerLetters>();
    }

    public void DigitSelect() 
    {   
        
        if (digitSelected >8) {
            digitSelected = 1;
        }

        if (firstCharacter.emptyValue == true && digitSelected == 1 && Input.GetKeyDown(KeyCode.Return))
        {
            
        }


    }

}
