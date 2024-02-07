using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Player _player;
        private IMovable _movement;
        private Vector3 _direction;
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        public void Constructor(IMovable movement, Player player)
        {
            _movement = movement;
            _player = player;
        }

        private void FixedUpdate()
        {
            ReadDirection();
            _movement.Move();
        }
        private void ReadDirection()
        {
            if (Input.GetKey(_player.KeyCodeBack))
            {
                _player.ChangeDir(new Vector3(0,0,-90));
            }
            if (Input.GetKey(_player.KeyCodeStraight))
            {
                _player.ChangeDir(new Vector3(0,0,90));
            }
            if (Input.GetKey(_player.KeyCodeLeft))
            {
                _player.ChangeDir(new Vector3(0,0,-180));
            }
            if (Input.GetKey(_player.KeyCodeRight))
            {
                _player.ChangeDir(new Vector3(0,0,-0));
            }
        }
    }
}
