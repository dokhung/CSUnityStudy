using UnityEngine;

namespace Script
{
    public class Enemy1 : Enemy
    {
        public float health = 50.0f;
        
        
        void Start()
        {
            Move();
        }
        
        void TakeDamege(int value)
        {
            health -= value;
            if (health <= 0)
            {
                Die();
            }
        }

        public void Move()
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50);
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
                Debug.Log("health : " + health);
                Destroy(coll.gameObject);
            }
        }
    }
}