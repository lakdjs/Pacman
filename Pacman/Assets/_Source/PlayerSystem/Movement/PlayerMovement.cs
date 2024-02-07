using UnityEngine;

namespace PlayerSystem.Movement
{
    public class PlayerMovement: IMovable
    {
        private float _speed;
        private Rigidbody2D _rb;
        private Transform _transform;
        
        public PlayerMovement(float speed, Rigidbody2D rigidbody, Transform transform)
        {
            _speed = speed;
            _rb = rigidbody;
            _transform = transform;
        }

        private void Movement()
        {
            _rb.MovePosition(_transform.position + _transform.right * _speed );
        }

        public void Move()
        {
            Movement();
        }
    }
}
