using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int addScore = 10;

    public GameObject pickUp;

    public Transform player;


    public ScoreManager scoreM;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        scoreM = GameObject.FindGameObjectWithTag("BM").GetComponent<ScoreManager>();
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, player.position) == 0)
        {
            scoreM.score += addScore;
            Destroy(pickUp);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreM.score += addScore;
            Destroy(this);
        }
    }*/
}
