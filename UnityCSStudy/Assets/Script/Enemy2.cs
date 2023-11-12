using UnityEngine;

namespace Script
{
    public class Enemy2 : Enemy
    {
        public float health = 50.0f;
        
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
            Move();
        }
        
        public void Move()
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * 50);
        }
        
        void TakeDamege(int value)
        {
            health -= value;
            if (health <= 0)
            {
                Die();
            }
        }
        
        public void Die()
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
}