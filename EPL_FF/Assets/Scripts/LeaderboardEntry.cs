using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardEntry : MonoBehaviour
{
    public TMP_Text initialsText;
    public TMP_Text timeText;
    public TMP_Text snowballText;

    public void Setup(string initials, float time, string snowballType)
    {
        initialsText.text = initials;
        timeText.text = FormatTime(time);
        snowballText.text = snowballType;
    }

    private string FormatTime(float time)
    {
        // Assuming time is in seconds
        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        int milliseconds = (int)((time - (minutes * 60) - seconds) * 100);
        return string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, milliseconds);
    }
}
