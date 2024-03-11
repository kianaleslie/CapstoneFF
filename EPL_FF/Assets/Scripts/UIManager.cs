using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Dropdown[] letterDropdowns;
    public GameObject dropdownPanel;
    public LeaderboardManager leaderboardManager;

    void Start()
    {
        PopulateDropdowns();
    }

    private void PopulateDropdowns()
    {
        var options = Enumerable.Range('A', 26).Select(i => new TMP_Dropdown.OptionData(((char)i).ToString())).ToList();

        foreach (var dropdown in letterDropdowns)
        {
            dropdown.ClearOptions();
            dropdown.AddOptions(options);
        }
    }

    // References to the dropdowns set through the inspector
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    public TMP_Dropdown dropdown3;

    // Reference to the save manager (to be added)
    public SaveManager saveManager;

    public void OnSaveButtonClicked()
    {
        string initials = dropdown1.options[dropdown1.value].text +
                          dropdown2.options[dropdown2.value].text +
                          dropdown3.options[dropdown3.value].text;

        // Placeholder time for now
        float time = 100.45f;

        saveManager.SaveData(initials, time, "SnowballType");

        // Immediately update the leaderboard after saving
        saveManager.LoadData();

        // Deactivate the dropdown panel
        dropdownPanel.SetActive(false);
    }
}
