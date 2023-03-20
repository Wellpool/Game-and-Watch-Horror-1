using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damage : MonoBehaviour
{
    public int damage = 1;
    public float cdDamage = 1f;
    private float _cdDamageTimer;
    
    
    public Transform player;

    public GameObject hazard;

    public HealthManager healthM;
    public SpiderActive spiderA;

    public UnityEvent hitSfx;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        healthM = GameObject.FindGameObjectWithTag("BM").GetComponent<HealthManager>();

        _cdDamageTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) == 0)
        {
            hitSfx.Invoke();
            healthM.health -= damage;
            spiderA.isActive = false;
            hazard.SetActive(false);
        }
       
    }
}
