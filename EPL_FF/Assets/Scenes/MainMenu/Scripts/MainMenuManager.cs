using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] public GameObject mainMenuCanvas;
    [SerializeField] public GameObject startMenuCanvas;
    [SerializeField] public GameObject creditsPanel;

    private void Start()
    {
        mainMenuCanvas.SetActive(false);
        startMenuCanvas.SetActive(true);
        creditsPanel.SetActive(false);
    }

    //kiana - activates main menu canvas and deactivates the start menu canvas
    //      - is used on the tap to start button on the start canvas 
    public void LoadMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        startMenuCanvas.SetActive(false);
        creditsPanel.SetActive(false);
    }

    //kiana - actiavtes the credits panel and deactives the main menu canvas
    //      - is used on the credits button on the start canvas 
    public void LoadCreditsPage()
    {
        mainMenuCanvas.SetActive(false);
        creditsPanel.SetActive(true);
    }

    //kiana - actiavtes the start canvas and deactives the main menu canvas and credits panel 
    //      - is used on the back button in the credits panel 
    public void LoadStartMenu()
    {
        mainMenuCanvas.SetActive(false);
        startMenuCanvas.SetActive(true);
        creditsPanel.SetActive(false);
    }
}