using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    public GameObject leaderboardPanel;
    public LeaderboardEntry leaderboardEntryPrefab;
    private List<LeaderboardEntry> leaderboardEntries = new List<LeaderboardEntry>();

    public void UpdateLeaderboard(List<Entry> entries)
    {
        // Clear the current leaderboard entries
        foreach (var entry in leaderboardEntries)
        {
            Destroy(entry.gameObject);
        }
        leaderboardEntries.Clear();

        // Sort the list of entries by time
        entries.Sort((a, b) => a.time.CompareTo(b.time));

        // Add new entries to the leaderboard
        foreach (var entryData in entries)
        {
            LeaderboardEntry entry = Instantiate(leaderboardEntryPrefab, leaderboardPanel.transform);
            entry.Setup(entryData.name, entryData.time, entryData.snowball);
            leaderboardEntries.Add(entry);
        }

        // Fill up remaining slots with "none"
        for (int i = leaderboardEntries.Count; i < 10; i++)
        {
            LeaderboardEntry entry = Instantiate(leaderboardEntryPrefab, leaderboardPanel.transform);
            entry.Setup("None", 0, "None");
            leaderboardEntries.Add(entry);
        }
    }

    [System.Serializable]
    public class Entry
    {
        public string name;
        public float time;
        public string snowball;
    }
}
