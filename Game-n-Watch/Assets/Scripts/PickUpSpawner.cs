using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUpSpawner : MonoBehaviour
{
    private int rowRandom;
    private int columnRandom;
    
    private int row = 1;
    private int column = 1;

    public float spawnTime = 10f;
    private float spawnTimer;
    
    public GameObject topLeft;
    public GameObject topMid;
    public GameObject topRight;
    public GameObject centerLeft;
    public GameObject centerMid;
    public GameObject centerRight;
    public GameObject botLeft;
    public GameObject botMid;
    public GameObject botRight;

    public GameObject pickUpSpawner;
    public GameObject pickUp;

    public Transform pickUpPos;

    //public Text rowText;
    //public Text columnText;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        rowRandom = Random.Range(0, 3);
        columnRandom = Random.Range(0, 3);

        //rowText.text = "Row: " + row.ToString();
        //columnText.text = "ColumnRandom: " + column.ToString();

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnTime;
            
            row = rowRandom;
            column = columnRandom;
            
            SpawnDrop();
        }
    }

    private void SpawnDrop()
    {
        //Bottom left
        if (row == 0 && column == 0)
        {
            pickUpSpawner.transform.position = botLeft.transform.position; 
        }
        
        //Bottom Middle
        if (row == 0 && column == 1)
        {
            pickUpSpawner.transform.position = botMid.transform.position;
        }
        
        //Bottom Right
        if (row == 0 && column == 2)
        {
            pickUpSpawner.transform.position = botRight.transform.position;
        }
        
        //Center Left
        if (row == 1 && column == 0)
        {
            pickUpSpawner.transform.position = centerLeft.transform.position;
        }
            
        //Center Mid
        if (row == 1 && column == 1)
        {
            pickUpSpawner.transform.position = centerMid.transform.position;    
        }
        
        //Center Right
        if (row == 1 && column == 2)
        {
            pickUpSpawner.transform.position = centerRight.transform.position;
        }
        
        //Top Left
        if (row == 2 && column == 0)
        {
            pickUpSpawner.transform.position = topLeft.transform.position;
        }
        
        //Top Middle
        if (row == 2 && column == 1)
        {
            pickUpSpawner.transform.position = topMid.transform.position;    
        }
        
        //Top Right
        if (row == 2 && column == 2)
        {
            pickUpSpawner.transform.position = topRight.transform.position;  
        }

        Instantiate(pickUp,pickUpPos.transform.position, Quaternion.identity);
    }
}
