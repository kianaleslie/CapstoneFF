using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoOpManager : MonoBehaviour
{
    GlobalDataManager globalDataManagerScript;

    [SerializeField] RawImage CoOpImage;

    void Start()
    {
        globalDataManagerScript = FindObjectOfType<GlobalDataManager>();
        globalDataManagerScript.playingCoopMode = false;
        CoOpImage.gameObject.SetActive(false);
    }
    public void ToggleCoOpMode()
    {
        globalDataManagerScript.playingCoopMode = !globalDataManagerScript.playingCoopMode;

        if(globalDataManagerScript.playingCoopMode)
        {
            CoOpImage.gameObject.SetActive(true);
        }
        else
        {
            CoOpImage.gameObject.SetActive(false);
        }
    }
}