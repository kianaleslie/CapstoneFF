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
        handleImage.GetComponent<RawImage>().texture = updateSnowballImages[globalDataManager.selectedSnowballID].gameObject.GetComponent<RawImage>().texture;
    }

    // Update is called once per frame
    void Update()
    {
        trackerValue = currentPosition.transform.position.z / endpoint.transform.position.z;

        trackerValue = trackerValue * 100;

        progressSlider.value = trackerValue;

        //handleImage.GetComponent<RawImage>().texture = updateSnowballImages[globalDataManager.selectedSnowballID].gameObject.GetComponent<RawImage>().texture;

        //for (int i = 0; i < updateSnowballImages.Length; i++)
        //{
        //    if (globalDataManager.selectedSnowballID == 0)
        //    {
        //        updateSnowballImages[0].gameObject.SetActive(true);
        //    }
        //}
    }
}
