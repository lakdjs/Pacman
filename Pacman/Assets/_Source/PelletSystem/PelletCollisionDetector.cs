using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace PelletSystem
{
    public class PelletCollisionDetector : MonoBehaviour
    {
        [SerializeField] private LayerMask pacmanMask;
        [SerializeField] private Pellet pellet;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if ((pacmanMask & (1 << other.gameObject.layer)) != 0)
            {
                this.gameObject.SetActive(false);
                pellet.RemovePellet();
            }
        }
    }
}
