using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    //kiana - this will potentially be used for exiting the leaderboard - as of 02/15 it's not being used
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    //kiana - this is being used on the main menu on the play button
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}