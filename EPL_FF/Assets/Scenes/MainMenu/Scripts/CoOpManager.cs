using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoOpManager : MonoBehaviour
{
    public bool isCoOpActive = false;
    [SerializeField] RawImage CoOpImage;

    void Start()
    {
        CoOpImage.gameObject.SetActive(false);
    }
    public void ToggleCoOpMode()
    {
        isCoOpActive = !isCoOpActive;
        if(isCoOpActive)
        {
            CoOpImage.gameObject.SetActive(true);
        }
        else
        {
            CoOpImage.gameObject.SetActive(false);
        }
    }
}