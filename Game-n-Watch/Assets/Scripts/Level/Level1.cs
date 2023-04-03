using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public GameObject level1;

    public LevelManager LM;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("BM").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LM.levelTime <= 0)
        {
            level1.SetActive(false);
        }
    }
}
