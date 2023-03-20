using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public int row;
    public int column;

    public float waitTime = 5f;
    private float waitTimer;

    private int _randomRow;
    private int _randomColumn;
    
    public GameObject topLeft;
    public GameObject topMid;
    public GameObject topRight;
    public GameObject centerLeft;
    public GameObject centerMid;
    public GameObject centerRight;
    public GameObject botLeft;
    public GameObject botMid;
    public GameObject botRight;

    public GameObject player;

    public GameObject spider;
    
    
    // Start is called before the first frame update
    void Start()
    {
        waitTimer = waitTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        waitTimer -= Time.deltaTime;
        
        _randomRow = Random.Range(0, 3);
        _randomColumn = Random.Range(0, 3);

        if (waitTimer <= 0)
        {
            NextLocation();
            waitTimer = waitTime;
        }

        GridCount();
        
        //Limits grid
        if (row < 0)
            row = 0;
        if (row > 2)
            row = 2;
        if (column <= 0)
            column = 0;
        if (column >= 2)
            column = 2;
    }

    private void NextLocation()
    {
        switch (_randomRow)
        {
            case 1:
                row++;
                break;
            case 0:
                row--;
                break;
        }

        switch (_randomColumn)
        {
            case 1:
                column++;
                break;
            case 0:
                column--;
                break;
        }
    }
    
    private void GridCount()
    {
        //Bottom left
        if (row == 0 && column == 0)
        {
            spider.transform.position = botLeft.transform.position;
        }
        
        //Bottom Middle
        if (row == 0 && column == 1)
        {
            spider.transform.position = botMid.transform.position;
        }
        
        //Bottom Right
        if (row == 0 && column == 2)
        {
            spider.transform.position = botRight.transform.position;
        }
        
        //Center Left
        if (row == 1 && column == 0)
        {
            spider.transform.position = centerLeft.transform.position;
        }
            
        //Center Mid
        if (row == 1 && column == 1)
        {
            spider.transform.position = centerMid.transform.position;
        }
        
        //Center Right
        if (row == 1 && column == 2)
        {
            spider.transform.position = centerRight.transform.position;
        }
        
        //Top Left
        if (row == 2 && column == 0)
        {
            spider.transform.position = topLeft.transform.position;
        }
        
        //Top Middle
        if (row == 2 && column == 1)
        {
            spider.transform.position = topMid.transform.position;
        }
        
        //Top Right
        if (row == 2 && column == 2)
        {
            spider.transform.position = topRight.transform.position;
        }
    }
}
