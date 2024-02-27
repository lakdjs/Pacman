using UnityEngine;

namespace PlayerSystem.Data
{
    public interface IPacUnit 
    {
        public float Speed { get; }
        public Vector2 CurrDir { get; }
        public Vector2 InitialDir { get; }
        public Vector2 NextDir { get; }
        public float SpeedMultiplier { get; }
        public Rigidbody2D Rb { get; }
        public Transform Transform { get; }
        public LayerMask ObstacleLayer { get; }
        public void ChangeDir(Vector2 dir);
        public void ChangeNextDir(Vector2 dir);
    }
}
