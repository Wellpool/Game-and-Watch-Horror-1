using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{
    public int addScore = 10;
    private float _spawnTime = 7f;

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
        _spawnTime -= Time.deltaTime;
        
        if (Vector2.Distance(transform.position, player.position) == 0)
        {
            scoreM.score += addScore;
            Destroy(pickUp);
        }
        
        if(_spawnTime <= 0)
            Destroy(gameObject);
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
