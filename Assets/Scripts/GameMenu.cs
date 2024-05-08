using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{

    [SerializeField] private Image newGameSubline;
    [SerializeField] private Image continueSubline;
    [SerializeField] private Image quitGameSubline;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject charCr;

    
    public int ngSubline = 1;
    public int cntSubline = 0;
    public int quitSubline = 0;

    public int menuOrder = 1;

    private int menuSelection;

    public void Awake() {
        
        newGameSubline.fillAmount = ngSubline;

        charCr.SetActive(false);
    }

    private void Update() {
        
        newGameSubline.fillAmount = ngSubline;
        continueSubline.fillAmount = cntSubline;
        quitGameSubline.fillAmount = quitSubline;

        if (Input.GetKeyDown(KeyCode.S))
        {
            menuOrder++;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            menuOrder--;
        }

        if (menuOrder == 1)
        {
            ngSubline = 1;
            cntSubline = 0;
            quitSubline = 0;
        } else if (menuOrder == 2)
        {
            ngSubline = 0;
            cntSubline = 1;
            quitSubline = 0;
        } else if (menuOrder == 3)
        { 
            ngSubline = 0;
            cntSubline = 0;
            quitSubline = 1;   
        }

        if (menuOrder > 3)
        {
            menuOrder = 1;
        }

        if (menuOrder < 1)
        {
            menuOrder = 3;
        }

        

        
        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (menuOrder == 1)
            {

                mainMenu.SetActive(false);
                charCr.SetActive(true);

            } else if (menuOrder == 2)
            {



            } else if (menuOrder == 3)
            {



            }

        }


    }

}
