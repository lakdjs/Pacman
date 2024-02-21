using PlayerSystem.Data;
using UnityEngine;

namespace EnemySystem
{
    public abstract class AEnemy : MonoBehaviour, IPacUnit
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public Vector2 CurrDir { get; private set; }
        [field: SerializeField] public Vector2 NextDir { get; private set; }
        [field: SerializeField] public float SpeedMultiplier { get; private set;}
        [field: SerializeField] public Rigidbody2D Rb { get; private set; }
        [field: SerializeField] public Transform Transform { get; private set; }
        [field: SerializeField] public LayerMask ObstacleLayer { get; private set;}
        public void ChangeDir(Vector2 dir)
        {
            CurrDir = dir;
        }

        public void ChangeNextDir(Vector2 dir)
        {
            NextDir = dir;
        }
    }
}
