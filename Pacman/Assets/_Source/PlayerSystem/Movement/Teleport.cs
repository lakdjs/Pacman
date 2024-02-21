using System;
using UnityEngine;

namespace PlayerSystem.Movement
{
    public class Teleport : MonoBehaviour
    {
        [SerializeField] private Transform connectPos;

        private void OnTriggerEnter2D(Collider2D other)
        {
            Vector3 position = other.transform.position;
            position.x = connectPos.position.x;
            position.y = connectPos.position.y;
            other.transform.position = position;
            
        }
    }
}
