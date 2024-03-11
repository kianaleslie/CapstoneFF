using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [System.Serializable]
    public class PlayerData
    {
        public string initials;
        public float time;
        public string snowballType;
    }

    public List<PlayerData> playerDataList = new List<PlayerData>();
    private string filePath;

    public LeaderboardManager leaderboardManager;

    void Awake()
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.xml");
        LoadData();
    }

    public void SaveData(string initials, float time, string snowballType)
    {
        PlayerData data = new PlayerData
        {
            initials = initials,
            time = time,
            snowballType = snowballType
        };

        playerDataList.Add(data);

        XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerData>));
        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(stream, playerDataList);
        }
    }

    public void LoadData()
    {
        if (File.Exists(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerData>));
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                playerDataList = serializer.Deserialize(stream) as List<PlayerData>;
            }

            // Convert PlayerData list to Entry list
            List<LeaderboardManager.Entry> entries = new List<LeaderboardManager.Entry>();
            foreach (var playerData in playerDataList)
            {
                LeaderboardManager.Entry entry = new LeaderboardManager.Entry()
                {
                    name = playerData.initials,
                    time = playerData.time,
                    snowball = playerData.snowballType
                };
                entries.Add(entry);
            }
            leaderboardManager.UpdateLeaderboard(entries);
        }
        else
        {
            Debug.Log("No save file found.");
        }
    }

}
