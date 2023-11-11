using System;
using UnityEngine;

namespace Script
{
    public class Player : MonoBehaviour
    {
        private float health = 100.0f;

        void TakeDamage(int value)
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
            TakeDamage(10);
            Destroy(coll.gameObject);
        }
    }
}