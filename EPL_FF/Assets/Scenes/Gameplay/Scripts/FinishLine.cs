using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other) // MAXWELL - Detects when the player reaches the finish line
    {
        if (other.GetComponentInParent<Rigidbody>().tag == "Player")
        {
            SnowballManager temp = other.GetComponentInParent<SnowballManager>();
            temp.playingGame = false;
            RaceManager temp2 = FindObjectOfType<RaceManager>();
            temp2.playingGame = false;
            temp2.countdownText.text = "GOAL!";
            StartCoroutine(GoToNextScene());
        }
    }

    public IEnumerator GoToNextScene() // MAXWELL - Sends the player to the next scene
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(2);
    }
}
