using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public int health;
    public int startHealth = 3;

    private bool _gameOver = false;

    public GameObject playerCtrl;
    
    
    
    public Text healthTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthTxt.text = "Health: " + health.ToString();

        if (health == 0)
            _gameOver = true;
        
        if (_gameOver)
        {
            Time.timeScale = 0f;
            playerCtrl.SetActive(false);
        }
    }
}
