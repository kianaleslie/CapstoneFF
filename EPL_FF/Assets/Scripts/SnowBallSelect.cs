using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowBallSelect : MonoBehaviour
{
    public List<Sprite> snowballList;
    public Image displaySnowball;
    public int index = 0;

    private void Start()
    {
        if (snowballList.Count > 0 && displaySnowball != null)
        {
            displaySnowball.sprite = snowballList[0];
        }
    }

    //kiana - this method runs through the snowballs in order (right button)
    public void SwitchSnowballRightButton()
    {
        index = (index + 1) % snowballList.Count;
        displaySnowball.sprite = snowballList[index];
    }

    //kiana - this method runs through the snowballs in reverse (left button)
    public void SwitchSnowballLeftButton()
    {
        index = (index - 1 + snowballList.Count) % snowballList.Count;
        displaySnowball.sprite = snowballList[index];
    }
}