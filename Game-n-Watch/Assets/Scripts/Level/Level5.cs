using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : MonoBehaviour
{
    public float levelTimer;
    public float levelTime = 40f;

    public GameObject level;

    public GameObject ghostSpawn1;

    public GameObject spiderSpawner1;
    public GameObject spiderSpawner2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        levelTimer = levelTime;
        ghostSpawn1.SetActive(false);
        
        spiderSpawner1.SetActive(false);
        spiderSpawner2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        levelTimer -= Time.deltaTime;
        
        if(levelTimer <= 8)
            ghostSpawn1.SetActive(true);

        if (levelTimer <= 10)
        {
            spiderSpawner1.SetActive(true);
            spiderSpawner2.SetActive(true);
        }
        
        if (levelTimer <= 0f)
        {
            level.SetActive(false);
        }
    }
}
