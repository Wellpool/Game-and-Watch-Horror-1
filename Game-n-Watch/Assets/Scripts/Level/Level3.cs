using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    public float levelTimer;
    public float levelTime = 40f;

    public GameObject level;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        levelTimer = levelTime;

    }

    // Update is called once per frame
    void Update()
    {
        levelTimer -= Time.deltaTime;

        
        if (levelTimer <= 0f)
        {
            level.SetActive(false);
        }
    }
}
