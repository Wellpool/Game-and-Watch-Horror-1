using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControler : MonoBehaviour
{
    public int row;
    public int column;

    public GameObject player;
    
    public GameObject topLeft2;
    public GameObject topLeft;
    public GameObject topMid;
    public GameObject topRight;
    public GameObject topRight2;
    public GameObject centerLeft2;
    public GameObject centerLeft;
    public GameObject centerMid;
    public GameObject centerRight;
    public GameObject centerRight2;
    public GameObject botLeft2;
    public GameObject botLeft;
    public GameObject botMid;
    public GameObject botRight;
    public GameObject botRight2;

    public UnityEvent moveSfx;
    

    // Start is called before the first frame update
    void Start()
    {
        row = 1;
        column = 2;
    }

    // Update is called once per frame
    void Update()
    {
        GridCount();

        //Works out direction
        if (Input.GetKeyDown(KeyCode.A))
        {
            column--;
            moveSfx.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            column++;
            moveSfx.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            row++;
            moveSfx.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            row--;
            moveSfx.Invoke();
        }
        
        //Limits grid
        if (row < 0)
            row = 0;
        if (row > 2)
            row = 2;
        if (column < 0)
            column = 0;
        if (column > 4)
            column = 4;
    }

    private void GridCount()
    {
        
        //Bottom left 2
        if (row == 0 && column == 0)
        {
            player.transform.position = botLeft2.transform.position;
        }
        
        //Bottom left
        if (row == 0 && column == 1)
        {
            player.transform.position = botLeft.transform.position;
        }
        
        //Bottom Middle
        if (row == 0 && column == 2)
        {
            player.transform.position = botMid.transform.position;
        }
        
        //Bottom Right
        if (row == 0 && column == 3)
        {
            player.transform.position = botRight.transform.position;
        }
        
        //Bottom Right 2
        if (row == 0 && column == 4)
        {
            player.transform.position = botRight2.transform.position;
        }
        
        //Center Left 2
        if (row == 1 && column == 0)
        {
            player.transform.position = centerLeft2.transform.position;
        }
        
        //Center Left
        if (row == 1 && column == 1)
        {
            player.transform.position = centerLeft.transform.position;
        }
            
        //Center Mid
        if (row == 1 && column == 2)
        {
            player.transform.position = centerMid.transform.position;
        }
        
        //Center Right
        if (row == 1 && column == 3)
        {
            player.transform.position = centerRight.transform.position;
        }
        
        //Center Right 2
        if (row == 1 && column == 4)
        {
            player.transform.position = centerRight2.transform.position;
        }
        
        //Top Left 2
        if (row == 2 && column == 0)
        {
            player.transform.position = topLeft2.transform.position;
        }
        
        //Top Left
        if (row == 2 && column == 1)
        {
            player.transform.position = topLeft.transform.position;
        }
        
        //Top Middle
        if (row == 2 && column == 2)
        {
            player.transform.position = topMid.transform.position;
        }
        
        //Top Right
        if (row == 2 && column == 3)
        {
            player.transform.position = topRight.transform.position;
        }
        
        //Top Right 2
        if (row == 2 && column == 4)
        {
            player.transform.position = topRight2.transform.position;
        }
    }
}
