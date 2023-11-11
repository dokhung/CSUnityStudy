using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 100.0f;

    void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }
    
    

    // public float GetHealth()
    // {
    //     return health;
    // }

    public float Health
    {
        get { return health; }
    }
    // // Start is called before the first frame update
    void Start()
    {
        Debug.Log("health : " + health);
    }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
    
    public void Die()
    {
        Destroy(this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamege(10);
            Destroy(coll.gameObject);
        }
    }

    
}
