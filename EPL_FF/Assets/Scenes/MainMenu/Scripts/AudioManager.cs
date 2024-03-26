using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    bool isMuted = false;

    //public MuteButtonToggle[] toggleImages;
    //public GameObject[] mutedImages;
    public GameObject mutedImage;

    private void Start()
    {
        //ToggleMutedImages();
        mutedImage.SetActive(false);
    }

    //kiana - this method is used to mute the audio and is used on the mute button on the main menu
    public void MuteAudio()
    {
        isMuted = !isMuted;

        if(isMuted)
        {
            audioSource.volume = 0f;
            mutedImage.SetActive(true);
        }
        else
        {
            audioSource.volume = 0.1f;
            mutedImage.SetActive(false);
        }
        ToggleMutedImages();
    }

    //kiana - this method is used to toggle each muted image accordingly on the 3 different menu canvases
    public void ToggleMutedImages()
    {
        //foreach (var toggleImage in toggleImages)
        //{
        //    if (toggleImage != null)
        //    {
        //        GameObject image = mutedImages[toggleImage.muteButtonIndex];

        //        if (image != null)
        //        {
        //            image.SetActive(isMuted);
        //        }
        //    }
        //}
    }
}

//[Serializable]
//public class MuteButtonToggle
//{
//    public int muteButtonIndex;
//}