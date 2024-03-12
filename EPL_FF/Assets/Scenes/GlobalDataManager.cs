using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDataManager : MonoBehaviour
{
    //[SerializeField] public FrozenFrenzySaveData myData; // FOR DATA THAT WILL ACTUALLY GET SAVED
    public bool playingCoopMode;
    public float currentRaceTime;
    public int snowballType;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        playingCoopMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
