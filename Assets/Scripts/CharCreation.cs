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

    [SerializeField] private string[] charMapDigts = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

    /*  Letters and Values:
        A = 0   N = 13  a = 26  n = 39
        B = 1   O = 14  b = 27  o = 40
        C = 2   P = 15  c = 28  p = 41
        D = 3   Q = 16  d = 29  q = 42
        E = 4   R = 17  e = 30  r = 43
        F = 5   S = 18  f = 31  s = 44
        G = 6   T = 19  g = 32  t = 45
        H = 7   U = 20  h = 33  u = 46
        I = 8   V = 21  i = 34  v = 47
        J = 9   W = 22  j = 35  w = 48
        K = 10  X = 23  k = 36  x = 49
        L = 11  Y = 24  l = 37  y = 50
        M = 12  Z = 25  m = 38  z = 51
    */


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
        firstCharacter = firstEmptyCharacter.GetComponent<PlayerLetters>();
        scndCharacter = scndEmptyCharacter.GetComponent<PlayerLetters>();
        thirdCharacter = thirdEmptyCharacter.GetComponent<PlayerLetters>();
        fourCharacter = fourEmptyCharacter.GetComponent<PlayerLetters>();
        fiveCharacter = fiveEmptyCharacter.GetComponent<PlayerLetters>();
        sixCharacter = sixEmptyCharacter.GetComponent<PlayerLetters>();
        sevenCharacter = sevenEmptyCharacter.GetComponent<PlayerLetters>();
        eightCharacter = eightEmptyCharacter.GetComponent<PlayerLetters>();
    }


    public void LetterSelected() {
        
    }
}
