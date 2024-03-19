using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowBallSelect : MonoBehaviour
{
    public List<RawImage> snowballList;
    public RawImage displaySnowball;
    public int index = 0;
    public GlobalDataManager globalDataManager;

    private void Start()
    {
        globalDataManager = FindObjectOfType<GlobalDataManager>();
        
        if (snowballList.Count > 0 && displaySnowball != null)
        {
            snowballList[0].gameObject.SetActive(true);
            snowballList[1].gameObject.SetActive(false);
            snowballList[2].gameObject.SetActive(false);
            snowballList[3].gameObject.SetActive(false);
            snowballList[4].gameObject.SetActive(false);
            snowballList[5].gameObject.SetActive(false);
            snowballList[6].gameObject.SetActive(false);
        }
    }

    //kiana - this method runs through the snowballs in order (right button)
    public void SwitchSnowballRightButton()
    {
        snowballList[index].gameObject.SetActive(false);
        index = (index + 1) % snowballList.Count;
        snowballList[index].gameObject.SetActive(true);
        globalDataManager.selectedSnowballID = index;
    }

    //kiana - this method runs through the snowballs in reverse (left button)
    public void SwitchSnowballLeftButton()
    {
        snowballList[index].gameObject.SetActive(false);
        index = (index - 1 + snowballList.Count) % snowballList.Count;
        snowballList[index].gameObject.SetActive(true);
        globalDataManager.selectedSnowballID = index;
    }
}