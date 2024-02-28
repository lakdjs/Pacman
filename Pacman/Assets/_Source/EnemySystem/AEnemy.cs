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
        [field: SerializeField] public float SpeedMultiplier { get; set;}
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

        public EnemyListener EnemyListener { get; private set; }

        private void Awake()
        {
            EnemyListener = FindObjectOfType<EnemyListener>();
            CurrDir = InitialDir;
            
        }

        private void Start()
        {
            
        }

        public void SetPosition(Vector3 position)
        {
            // Keep the z-position the same since it determines draw depth
            position.z = transform.position.z;
            transform.position = position;
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
        public void ResetState()
        {
            gameObject.SetActive(true);
            
            Frightened.Disable();
            Chase.Disable();
            Scatter.Enable();

            if (Home != initialBehavior) {
                Home.Disable();
            }

            if (initialBehavior != null) {
                initialBehavior.Enable();
            }
        }
    }
}
