using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreTxt;

    public int score;


    private void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + score.ToString();
    }
}
