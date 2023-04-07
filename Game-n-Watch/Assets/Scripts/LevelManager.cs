using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int levelCount;
    public float waitLevel = 5f;
    public float waitLevelCount;
    public float levelTime = 40f;
    public float levelTimeCount;

    public bool levelWait;
    public bool levelPlay;
    
    
    public GameObject player;
    
    public GameObject level1,level2,level3,level4,level5,level6,level7,level8,level9,level10;
    public GameObject board1,board2,board3,board4,board5,board6,board7,board8,board9,board10,boardEnd;

    public ScoreManager scoreM;
    public HealthManager healthM;






    private void Start()
    {
        waitLevelCount = waitLevel;
        levelTimeCount = levelTime;

        levelWait = false;
        levelPlay = false;
        
        player.SetActive(false);
        
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);

        board1.SetActive(false);
        board2.SetActive(false);
        board3.SetActive(false);
        board4.SetActive(false);
        board5.SetActive(false);
        board6.SetActive(false);
        board7.SetActive(false);
        board8.SetActive(false);
        board9.SetActive(false);
        board10.SetActive(false);
        boardEnd.SetActive(false);
        
        scoreM = GameObject.FindGameObjectWithTag("BM").GetComponent<ScoreManager>();
        healthM = GameObject.FindGameObjectWithTag("BM").GetComponent<HealthManager>();
    }

    private void Update()
    {

        if (levelWait)
        {
            waitLevelCount -= Time.deltaTime;

            switch (levelCount)
            {
                case (1):
                    board1.SetActive(true);
                    break;
                case (2):
                    board2.SetActive(true);
                    break;
                case (3):
                    board3.SetActive(true);
                    break;
                case (4):
                    board4.SetActive(true);
                    break;
                case (5):
                    board5.SetActive(true);
                    break;
                case (6):
                    board6.SetActive(true);
                    break;
                case (7):
                    board7.SetActive(true);
                    break;
                case (8):
                    board8.SetActive(true);
                    break;
                case (9):
                    board9.SetActive(true);
                    break;
                case (10):
                    board10.SetActive(true);
                    break;
                case (11):
                    break;
            }
        }

        if (waitLevelCount <= 0)
        {
            levelPlay = true;
            levelWait = false;
            waitLevelCount = waitLevel;        
            board1.SetActive(false);
            board2.SetActive(false);
            board3.SetActive(false);
            board4.SetActive(false);
            board5.SetActive(false);
            board6.SetActive(false);
            board7.SetActive(false);
            board8.SetActive(false);
            board9.SetActive(false);
            board10.SetActive(false);
            boardEnd.SetActive(false);
        }

        if (levelPlay)
            PlayLevel();
        
        
    }

    private void PlayLevel()
    {
        switch (levelCount)
        {
            case (1):
                player.SetActive(true);
                level1.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (2):
                player.SetActive(true);
                level2.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (3):
                player.SetActive(true);
                level3.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (4):
                player.SetActive(true);
                level4.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (5):
                player.SetActive(true);
                level5.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (6):
                player.SetActive(true);
                level6.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (7):
                player.SetActive(true);
                level2.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (8):
                player.SetActive(true);
                level8.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (9):
                player.SetActive(true);
                level2.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
            case (10):
                player.SetActive(true);
                level2.SetActive(true);
                levelTimeCount -= Time.deltaTime;
                break;
        }

        if (levelTimeCount <= 0f)
        {
            levelPlay = false;
            levelTimeCount = levelTime;
            levelWait = true;
            player.SetActive(false);
            scoreM.score += 100;
            healthM.health++;
            levelCount++;
        }

    }
}
