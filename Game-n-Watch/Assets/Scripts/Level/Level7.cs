using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7 : MonoBehaviour
{
    public float levelTimer;
    public float levelTime = 40f;

    public GameObject level;

    //public GameObject ghostSpawn1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        levelTimer = levelTime;
        //ghostSpawn1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        levelTimer -= Time.deltaTime;
        
        /*if(levelTimer <= 35)
            ghostSpawn1.SetActive(true);*/
        
        if (levelTimer <= 0f)
        {
            level.SetActive(false);
        }
    }
}
