using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    [SerializeField] GameObject endpoint, currentPosition;
    [SerializeField] Slider progressSlider;
    [SerializeField] GameObject handleImage;
    [SerializeField] GameObject[] updateSnowballImages;
     GlobalDataManager globalDataManager;
    float trackerValue;

    // Start is called before the first frame update
    void Start()
    {
        globalDataManager = FindObjectOfType<GlobalDataManager>();

        updateSnowballImages[0].SetActive(globalDataManager.selectedSnowballID == 0 ? true : false);
        updateSnowballImages[1].SetActive(globalDataManager.selectedSnowballID == 1 ? true : false);
        updateSnowballImages[2].SetActive(globalDataManager.selectedSnowballID == 2 ? true : false);
        updateSnowballImages[3].SetActive(globalDataManager.selectedSnowballID == 3 ? true : false);
        updateSnowballImages[4].SetActive(globalDataManager.selectedSnowballID == 4 ? true : false);
        updateSnowballImages[5].SetActive(globalDataManager.selectedSnowballID == 5 ? true : false);
        updateSnowballImages[6].SetActive(globalDataManager.selectedSnowballID == 6 ? true : false);

        handleImage.GetComponent<RawImage>().texture = updateSnowballImages[globalDataManager.selectedSnowballID].gameObject.GetComponent<RawImage>().texture;
    }

    // Update is called once per frame
    void Update()
    {
        trackerValue = currentPosition.transform.position.z / endpoint.transform.position.z;

        trackerValue = trackerValue * 100;

        progressSlider.value = trackerValue;

        //handleImage.GetComponent<RawImage>().texture = updateSnowballImages[globalDataManager.selectedSnowballID].gameObject.GetComponent<RawImage>().texture;

        
    }
}
