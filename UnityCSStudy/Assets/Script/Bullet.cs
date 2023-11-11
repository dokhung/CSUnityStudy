using System;
using UnityEngine;

namespace Script
{
    public class Bullet : MonoBehaviour
    {
        private void Start()
        {
            Invoke("DestroySelf",2.0f);
        }

        void DestroySelf()
        {
            Destroy(gameObject);
        }
    }
}