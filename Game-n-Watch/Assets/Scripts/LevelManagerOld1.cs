using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerOld : MonoBehaviour
{
    public float levelTime;
    public float levelTimer;
    public float levelCount;
    public float levelWaitTime = 5;
    public float levelWaitCounter;

    public bool waitLevel = false;
    private bool timeLevelWaited = false;

    public Text timeTxt;

    public GameObject level1;
    
    public ScoreManager scoreM;
    

    void Start()
    {
        timeLevelWaited = false;
        levelWaitCounter = levelWaitTime;
        levelTime = levelTimer;

        scoreM = GameObject.FindGameObjectWithTag("BM").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitLevel)
            levelWaitCounter -= Time.deltaTime;
        
        if (levelWaitCounter <= 0)
            timeLevelWaited = true;
        
        if (timeLevelWaited = true)
        {
            PlayLevel();
        }

        timeTxt.text = "Time: " + levelTime.ToString();
    }

    private void PlayLevel()
    {
        switch (levelCount)
        {
            case (1):
                level1.SetActive(true);
                levelTime -= Time.deltaTime;
                break;
            
            default:
                break;

        }

        if (levelTime <= 0)
        {
            levelWaitCounter = levelWaitTime;
            levelTime = levelTimer;
            timeLevelWaited = false;
        }
    }
}
