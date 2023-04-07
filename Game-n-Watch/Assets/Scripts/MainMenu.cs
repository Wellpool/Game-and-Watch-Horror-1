using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject mainMenu;

    public LevelManager lm;

    private void Start()
    {
        gameUI.SetActive(false);
        
        lm = GameObject.FindGameObjectWithTag("BM").GetComponent<LevelManager>();
    }


    public void PlayGame()
    {
        //SceneManager.LoadScene(1); // Load the first level
        gameUI.SetActive(true);
        mainMenu.SetActive(false);
        lm.levelWait = true;

    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game
        Debug.Log("quit");
    }
}
