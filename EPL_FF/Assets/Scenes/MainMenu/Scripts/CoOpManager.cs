using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoOpManager : MonoBehaviour
{
    public bool isCoOpActive = false;
    [SerializeField] RawImage coOpImage;
    [SerializeField] RawImage deactivatedImage;

    void Start()
    {
        coOpImage.gameObject.SetActive(false);
        deactivatedImage.gameObject.SetActive(true);
    }

    //kiana - this method toggles the co-op mode on/off as well as the images
    public void ToggleCoOpMode()
    {
        isCoOpActive = !isCoOpActive;
        if (isCoOpActive)
        {
            coOpImage.gameObject.SetActive(true);
            deactivatedImage.gameObject.SetActive(false);
        }
        else
        {
            coOpImage.gameObject.SetActive(false);
            deactivatedImage.gameObject.SetActive(true);
        }
    }
}