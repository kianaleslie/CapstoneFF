using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Josh - Main UI handler.
    public TMP_Dropdown[] letterDropdowns;
    public GameObject dropdownPanel;
    public LeaderboardManager leaderboardManager;

    void Start()
    {
        PopulateDropdowns();
    }

    // Josh - Method for populating the values of the dropdowns with letters from A to Z.
    private void PopulateDropdowns()
    {
        var options = Enumerable.Range('A', 26).Select(i => new TMP_Dropdown.OptionData(((char)i).ToString())).ToList();

        foreach (var dropdown in letterDropdowns)
        {
            dropdown.ClearOptions();
            dropdown.AddOptions(options);
        }
    }

    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    public TMP_Dropdown dropdown3;

    public SaveManager saveManager;

    public RaceManager raceManager;

    // Josh - This method is for saving the data that has been recorded from the last game stage and then updating the ranking in real time.
    public void OnSaveButtonClicked()
    {
        string initials = dropdown1.options[dropdown1.value].text +
                          dropdown2.options[dropdown2.value].text +
                          dropdown3.options[dropdown3.value].text;

        float time = PlayerPrefs.GetFloat("RaceTime", 0.0f);

        saveManager.SaveData(initials, time, "SnowballType");

        // Immediately update the leaderboard after saving
        saveManager.LoadData();

        // Deactivate the dropdown panel
        dropdownPanel.SetActive(false);

        StartCoroutine(ChangeSceneAfterTime(10f));
    }

    // Josh - This method is for changing the scene from the Leaderboard to MainMenu after 10 secs (Adjusting the secs is at the OnSaveButtonClicked Method above.)
    private IEnumerator ChangeSceneAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(0);
    }
}
