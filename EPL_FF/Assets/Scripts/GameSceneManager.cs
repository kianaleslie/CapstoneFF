using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    SnowBallSelect snowBalls;
    //public GameObject[] snowballPrefabs;

    //private void Start()
    //{
    //    snowballPrefabs[0].SetActive(true);
    //    snowballPrefabs[1].SetActive(false);
    //    snowballPrefabs[2].SetActive(false);
    //    snowballPrefabs[3].SetActive(false);
    //    snowballPrefabs[4].SetActive(false);
    //    snowballPrefabs[5].SetActive(false);
    //    snowballPrefabs[6].SetActive(false);
    //}

    //kiana - this will potentially be used for exiting the leaderboard - as of 02/15 it's not being used
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    //kiana - this is being used on the main menu on the play button
    public void LoadGame()
    {
        SceneManager.LoadScene(1);

        //if (snowBalls.snowballList[0] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(true);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[1] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(true);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[2] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(true);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[3] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(true);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[4] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(true);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[5] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(true);
        //    snowballPrefabs[6].SetActive(false);
        //}
        //if (snowBalls.snowballList[6] == snowBalls.displaySnowball)
        //{
        //    snowballPrefabs[0].SetActive(false);
        //    snowballPrefabs[1].SetActive(false);
        //    snowballPrefabs[2].SetActive(false);
        //    snowballPrefabs[3].SetActive(false);
        //    snowballPrefabs[4].SetActive(false);
        //    snowballPrefabs[5].SetActive(false);
        //    snowballPrefabs[6].SetActive(true);
        //}
    }
}