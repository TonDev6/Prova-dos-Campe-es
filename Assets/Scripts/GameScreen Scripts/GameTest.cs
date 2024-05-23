using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTest : MonoBehaviour
{

    [SerializeField] private GameObject textBox;
    [SerializeField] private GameText textArchive;
    [SerializeField] private Text gameText;


    public int textSelection = 0;

    private void Awake() {
        textArchive = textBox.GetComponent<GameText>();
        gameText = textBox.GetComponent<Text>();
    }


    private void Update() {

        if (textSelection == 0) {
            gameText.text = textArchive.introTexts[0];
        } else if (textSelection == 1) {
            gameText.text = textArchive.introTexts[1];
        } else if (textSelection == 2) {
            gameText.text = textArchive.introTexts[2];
        } else if (textSelection == 3) {
            gameText.text = textArchive.introTexts[3];
        } else if (textSelection == 4) {
            gameText.text = textArchive.introTexts[4];
        } else if (textSelection == 5) {
            gameText.text = textArchive.introTexts[5];
        } else if (textSelection == 6) {
            gameText.text = textArchive.introTexts[6];
        } else if (textSelection == 7) {
            gameText.text = textArchive.introTexts[7];
        } else if (textSelection == 8) {
            gameText.text = textArchive.introTexts[8];
        } else if (textSelection == 9) {
            gameText.text = textArchive.introTexts[9];
        } else if (textSelection == 10) {
            gameText.text = textArchive.introTexts[10];
        } else if (textSelection == 11) {
            gameText.text = textArchive.introTexts[11];
        } else if (textSelection == 12) {
            gameText.text = textArchive.introTexts[12];
        } else if (textSelection == 13) {
            gameText.text = textArchive.introTexts[13];
        } else if (textSelection == 14) {
            gameText.text = textArchive.introTexts[14];
        } else if (textSelection == 15) {
            gameText.text = textArchive.introTexts[15];
        }

    }

    public void NextText() {
        textSelection++;
    }
}
