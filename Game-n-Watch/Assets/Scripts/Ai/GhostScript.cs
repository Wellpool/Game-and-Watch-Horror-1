using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    public float ghostTime = 5f;
    private float ghostActTime;

    public float moveTime = 1f;
    private float moveTimer;
    private bool walk = false;
    public float walkTime = 2f;
    private float walkTimer;
    public float speed = 0.5f;

    public GameObject ghost;

    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        ghostActTime = ghostTime;
        moveTimer = moveTime;
        walkTimer = walkTime;
        walk = false;
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ghostActTime -= Time.deltaTime;
        moveTimer -= Time.deltaTime;
        
        

        if (ghostActTime <= 0)
        {
            ghost.SetActive(false);
        }

        if (moveTimer <0)
            walk = true;

        if (walk)
            MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        walkTimer -= Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
