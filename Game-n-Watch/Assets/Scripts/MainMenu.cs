using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MainGame;
    
    public void Start()
    {
        MainGame.SetActive(false);
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene(1); // Load the first level
        MainGame.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game
        Debug.Log("quit");
    }
}
