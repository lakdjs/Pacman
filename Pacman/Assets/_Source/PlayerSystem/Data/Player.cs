using System;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

namespace PlayerSystem.Data
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour, IPacUnit
    {
        [field: SerializeField] public int PlayerLives { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
        //[field: SerializeField] public float PlayerSpeed { get; private set; }
        [field: SerializeField] public float PlayerRotationSpeed { get; private set; }
        [field: SerializeField] public float SpeedMultiplier { get; private set; }
        [field: SerializeField] public Rigidbody2D Rb { get; private set; }
        [field: SerializeField] public Transform Transform { get; private set; }
        [field: SerializeField] public LayerMask ObstacleLayer { get; private set; }
        [field: SerializeField] public Vector2 CurrDir { get; private set; }
        [field: SerializeField] public Vector2 InitialDir { get; private set; }
        [field: SerializeField] public Vector2 NextDir { get; private set; }
        [field: SerializeField] public Vector3 StartPos { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeLeft { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeRight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeStraight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeBack { get; private set; }
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private new Collider2D collider;
        [SerializeField] private AnimatedSprite deathSequence;

        private void Awake()
        {
            Rb = GetComponent<Rigidbody2D>();
            StartPos = transform.position;
            CurrDir = InitialDir;
        }

        public void ChangeDir(Vector2 dir)
        {
            CurrDir = dir;
        }

        public void ChangeNextDir(Vector2 dir)
        {
            NextDir = dir;
        }

        public void Rotate()
        {
            
        }
        public void ResetState()
        {
            enabled = true;
            spriteRenderer.enabled = true;
            collider.enabled = true;
            deathSequence.enabled = false;
            SpeedMultiplier = 1f;
            CurrDir = InitialDir;
            NextDir = Vector2.zero;
            transform.position = StartPos;
            Rb.isKinematic = false;
            enabled = true;
            gameObject.SetActive(true);
        }
        
    }
}
