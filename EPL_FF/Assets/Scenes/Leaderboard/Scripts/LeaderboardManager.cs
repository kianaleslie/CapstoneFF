using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh - For managing the leaderboard ranking and template placing.
public class LeaderboardManager : MonoBehaviour
{
    public GameObject leaderboardPanel;
    public LeaderboardEntry leaderboardEntryPrefab;
    private List<LeaderboardEntry> leaderboardEntries = new List<LeaderboardEntry>();

    public void UpdateLeaderboard(List<Entry> entries)
    {
        // Josh - Leaderboard Clear.
        foreach (var entry in leaderboardEntries)
        {
            Destroy(entry.gameObject);
        }
        leaderboardEntries.Clear();

        // Josh - Sort ranking via lowest time of completion of stage.
        entries.Sort((a, b) => a.time.CompareTo(b.time));

        // Josh - Adds new entries to the leaderboard.
        foreach (var entryData in entries)
        {
            LeaderboardEntry entry = Instantiate(leaderboardEntryPrefab, leaderboardPanel.transform);
            entry.Setup(entryData.name, entryData.time, entryData.snowball);
            leaderboardEntries.Add(entry);
        }

        // Josh - If there are no entries in the leaderboard then it says none.
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
