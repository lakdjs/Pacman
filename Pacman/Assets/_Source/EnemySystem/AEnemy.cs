using System;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;

namespace EnemySystem
{
    public abstract class AEnemy : MonoBehaviour, IPacUnit
    {
        [field: SerializeField] public int Points { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public Vector2 CurrDir { get; private set; }
        [field: SerializeField] public Vector2 InitialDir { get; private set; }
        [field: SerializeField] public Vector2 NextDir { get; private set; }
        [field: SerializeField] public float SpeedMultiplier { get; private set;}
        [field: SerializeField] public Rigidbody2D Rb { get; private set; }
        [field: SerializeField] public Transform Transform { get; private set; }
        [field: SerializeField] public Transform Target { get; private set; }
        [field: SerializeField] public LayerMask ObstacleLayer { get; private set;}
        
        
        [field: SerializeField] public EnemyHome Home { get; private set; }
        [field: SerializeField] public EnemyScatter Scatter { get; private set; }
        [field: SerializeField] public EnemyChase Chase { get; private set; }
        [field: SerializeField] public EnemyFrightened Frightened { get; private set; }
        [field: SerializeField] public EnemyBehaviour initialBehavior;

        public PlayerMovement Movement { get; private set; }

        private void Awake()
        {
            CurrDir = InitialDir;
        }

        public void Construct(PlayerMovement playerMovement)
        {
            Movement = playerMovement;
        }
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
