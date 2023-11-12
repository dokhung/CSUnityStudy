using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 50.0f;
    
    public float Health
    {
        get { return health; }
    }
    void Start()
    {
        Debug.Log("health : " + health);
    }

    void TakeDamege(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamege(10);
            Debug.Log("health : " + health);
            Destroy(coll.gameObject);
        }
    }
    
    
    
   
}




