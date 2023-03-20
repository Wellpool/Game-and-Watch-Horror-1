using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderActive : MonoBehaviour
{
    public float activeTime = 5f;
    private float activeTimer;
    public float notActiveTime = 5f;
    private float notActiveTimer;

    public bool isActive;

    public GameObject spider;

    // Start is called before the first frame update
    void Start()
    {
        activeTimer = activeTime;
        notActiveTimer = notActiveTime;

        isActive = false;
        
        spider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            spider.SetActive(true);
            activeTimer -= Time.deltaTime;
            notActiveTimer = activeTime;
        }
        else
        {
            spider.SetActive(false);
            activeTimer = activeTime;
            notActiveTimer -= Time.deltaTime;
        }

        if (notActiveTimer <= 0)
        {
            isActive = true;
            notActiveTimer = activeTime;
        }
    }
}
