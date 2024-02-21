using PlayerSystem.Data;
using UnityEngine;

namespace PlayerSystem.Movement
{
    public class PlayerMovement: IMovable
    {
        private IPacUnit _unit;
        
        public PlayerMovement(IPacUnit unit)
        {
            _unit = unit;
        }

        private void Movement()
        {
            Vector2 pos = _unit.Rb.position;
            Vector2 translation = _unit.CurrDir *
                                  _unit.Speed *
                                  _unit.SpeedMultiplier *
                                  Time.fixedDeltaTime;
            _unit.Rb.MovePosition(pos + translation);
        }

        public void SetDir(Vector2 dir)
        {
            if (!DoesHitWall(dir))
            {
                _unit.ChangeDir(dir);
                _unit.ChangeNextDir(Vector2.zero);
            }
            else
            {
                _unit.ChangeNextDir(dir);
            }
        }
        
        public void Move()
        {
            Movement();
        }

        private bool DoesHitWall(Vector2 dir)
        {
            RaycastHit2D hit = Physics2D.BoxCast(_unit.Transform.position,
                Vector2.one * 0.75f, 0.0f,
                dir,
                1.5f,
                _unit.ObstacleLayer);
            return hit.collider != null;
        }
    }
}
