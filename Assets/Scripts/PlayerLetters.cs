using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLetters : MonoBehaviour
{

    [SerializeField] public Text thisLetter;

    public bool emptyValue = true;

    public string letterValue;

    private void Start() {
        thisLetter = this.GetComponent<Text>();

        letterValue = thisLetter.text;
    }
    private void Update() {
        
    }
}
