using System;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Player _player;
        private PlayerMovement _movement;
        private Vector3 _direction;
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public void Constructor(PlayerMovement movement, Player player)
        {
            _movement = movement;
            _player = player;
        }

        private void Update()
        {
            if (_player.NextDir != Vector2.zero)
            {
                _movement.SetDir(_player.NextDir);
            }
            ReadDirection();
        }

        private void FixedUpdate()
        {
            _movement.Move();
        }
        private void ReadDirection()
        {
            if (Input.GetKeyDown(_player.KeyCodeBack))
            {
                _movement.SetDir(Vector2.down);
                _player.Rotate();
            }
            else if (Input.GetKeyDown(_player.KeyCodeStraight))
            {
                _movement.SetDir(Vector2.up);
                _player.Rotate();
            }
            else if (Input.GetKeyDown(_player.KeyCodeLeft))
            {
                _movement.SetDir(Vector2.left);
                _player.Rotate();
            }
            else if (Input.GetKeyDown(_player.KeyCodeRight))
            {
                _movement.SetDir(Vector2.right);
                _player.Rotate();
            }
            
        }
    }
}
