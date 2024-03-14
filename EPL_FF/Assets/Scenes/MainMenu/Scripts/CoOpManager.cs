using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoOpManager : MonoBehaviour
{
    public GlobalDataManager globalDataManager;

    public bool isCoOpActive = false;
    [SerializeField] RawImage coOpImage;
    [SerializeField] RawImage deactivatedImage;

    void Start()
    {
        globalDataManager = FindObjectOfType<GlobalDataManager>();
        coOpImage.gameObject.SetActive(false);
        deactivatedImage.gameObject.SetActive(true);
    }

    //kiana - this method toggles the co-op mode on/off as well as the images
    public void ToggleCoOpMode()
    {
        isCoOpActive = !isCoOpActive;
        if (isCoOpActive)
        {
            globalDataManager.playingCoopMode = true;
            coOpImage.gameObject.SetActive(true);
            deactivatedImage.gameObject.SetActive(false);
        }
        else
        {
            globalDataManager.playingCoopMode = false;
            coOpImage.gameObject.SetActive(false);
            deactivatedImage.gameObject.SetActive(true);
        }
    }
}