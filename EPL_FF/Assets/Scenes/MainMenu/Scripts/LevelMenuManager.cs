using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenuManager : MonoBehaviour
{
    //this script handled the level selection buttons and updated the ui accrodingly, but we are no longer doing multiple levels

    //[SerializeField] public GameObject mainMenuCanvas;
    //[SerializeField] public GameObject jungleLevelCanvas;
    //[SerializeField] public GameObject volcanoLevelCanvas;

    //[SerializeField] public Image[] leftButton;
    //[SerializeField] public Image[] rightButton;

    ////kiana - start with the default frozen menu 
    //private void Start()
    //{
    //    LoadMainMenu();
    //}

    ////kiana - set active the frozen level ui 
    //public void LoadMainMenu()
    //{
    //    mainMenuCanvas.SetActive(true);
    //    jungleLevelCanvas.SetActive(false);
    //    volcanoLevelCanvas.SetActive(false);
    //    leftButton[0].gameObject.SetActive(true);
    //    rightButton[0].gameObject.SetActive(true);
    //    leftButton[1].gameObject.SetActive(false);
    //    rightButton[1].gameObject.SetActive(false);
    //    leftButton[2].gameObject.SetActive(false);
    //    rightButton[2].gameObject.SetActive(false);
    //}

    ////kiana - set active the jungle level ui 
    //public void LoadJungleLevel()
    //{
    //    mainMenuCanvas.SetActive(false);
    //    jungleLevelCanvas.SetActive(true);
    //    volcanoLevelCanvas.SetActive(false);
    //    leftButton[0].gameObject.SetActive(false);
    //    rightButton[0].gameObject.SetActive(false);
    //    leftButton[1].gameObject.SetActive(true);
    //    rightButton[1].gameObject.SetActive(true);
    //    leftButton[2].gameObject.SetActive(false);
    //    rightButton[2].gameObject.SetActive(false);
    //}

    ////kiana - set active the volcano level ui 
    //public void LoadVolcanoLevel()
    //{
    //    mainMenuCanvas.SetActive(false);
    //    jungleLevelCanvas.SetActive(false);
    //    volcanoLevelCanvas.SetActive(true);
    //    leftButton[0].gameObject.SetActive(false);
    //    rightButton[0].gameObject.SetActive(false);
    //    leftButton[1].gameObject.SetActive(false);
    //    rightButton[1].gameObject.SetActive(false);
    //    leftButton[2].gameObject.SetActive(true);
    //    rightButton[2].gameObject.SetActive(true);
    //}
}