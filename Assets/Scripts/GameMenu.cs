using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    [SerializeField] private Image newGameSubline;
    [SerializeField] private Image continueSubline;
    [SerializeField] private Image quitGameSubline;

    private MenuControls menuControls;
    
    
    public int ngSubline = 1;
    public int cntSubline = 0;
    public int quitSubline = 0;

    public int menuOrder = 1;

    private string ngScene;

    private void Awake() {

        newGameSubline.fillAmount = ngSubline;

        menuControls = new MenuControls();

        ngScene = "CharacterCreation";

    }

    private void OnUP() {
        menuOrder--;
    }

    private void OnDOWN() {
        menuOrder++;
    }

    private void OnSubmit() {
        if (menuOrder == 1)
        {

           SceneManager.LoadScene(ngScene);

        }
    }


    void Update()
    {

        newGameSubline.fillAmount = ngSubline;
        continueSubline.fillAmount = cntSubline;
        quitGameSubline.fillAmount = quitSubline;
        
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

    }
}
