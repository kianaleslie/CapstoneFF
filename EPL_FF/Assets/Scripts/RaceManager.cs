using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceManager : MonoBehaviour
{
    [SerializeField] SnowballManager snowballManager;
    [SerializeField] public TMP_Text countdownText;
    [SerializeField] TMP_Text timeText;
    [SerializeField] TMP_Text powerBallCountText;
    [SerializeField] Button powerBoostButton;
    public bool playingGame;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        playingGame = false;
        powerBoostButton.interactable = false;
        time = 0.0f;
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (playingGame == true)
        {
            timeText.text = "Time: " + time.ToString("F2");
        }  
    }

    private void FixedUpdate()
    {
        if (playingGame == true)
        {
            time += Time.deltaTime;


            if (snowballManager.powerBallCount <= 19)
            {
                powerBallCountText.text = snowballManager.powerBallCount.ToString() + "/20";
                powerBoostButton.interactable = false;
            }
            else
            {
                powerBoostButton.interactable = true;
                powerBallCountText.text = "Boost!";
            }



        }
    }

    public IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2.0f);
        countdownText.text = "3";
        yield return new WaitForSeconds(1.0f);
        countdownText.text = "2";
        yield return new WaitForSeconds(1.0f);
        countdownText.text = "1";
        yield return new WaitForSeconds(1.0f);
        countdownText.text = "GO!";
        playingGame = true;
        snowballManager.playingGame = true;
        yield return new WaitForSeconds(1.0f);
        countdownText.text = "";
    }
}
