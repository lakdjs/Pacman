using System;
using UnityEngine;

namespace PlayerSystem.Data
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public int PlayerLives { get; private set; }
        [field: SerializeField] public float PlayerSpeed { get; private set; }
        [field: SerializeField] public float PlayerSpeedMultiplier { get; private set; }
        [field: SerializeField] public Rigidbody2D PlayerRb { get; private set; }
        [field: SerializeField] public LayerMask ObstacleLayer { get; private set; }
        [field: SerializeField] public Vector2 CurrDir { get; private set; }
        [field: SerializeField] public Vector2 NextDir { get; private set; }
        [field: SerializeField] public Vector3 StartPos { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeLeft { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeRight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeStraight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeBack { get; private set; }

        private void Awake()
        {
            PlayerRb = GetComponent<Rigidbody2D>();
            StartPos = transform.position;
        }

        public void ChangeDir(Vector3 dir)
        {
           transform.rotation = Quaternion.Euler(dir);
        }
    }
}
