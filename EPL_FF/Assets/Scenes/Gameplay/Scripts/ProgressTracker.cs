using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    [SerializeField] GameObject endpoint, currentPosition;
    [SerializeField] UnityEngine.UI.Slider progressSlider;
    float trackerValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trackerValue = currentPosition.transform.position.z / endpoint.transform.position.z;

        trackerValue = trackerValue * 100;

        progressSlider.value = trackerValue;
    }
}
