using UnityEngine;

namespace EnemySystem
{
    public class EnemyChase : EnemyBehaviour
    {
        private void OnDisable()
        {
            Enemy.Scatter.Enable();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Node node = other.GetComponent<Node>();
            
            if (node != null && enabled && !Enemy.Frightened.enabled)
            {
                Vector2 direction = Vector2.zero;
                float minDistance = float.MaxValue;
                
                foreach (Vector2 availableDirection in node.AvailableDirections)
                {
                    Vector3 newPosition = transform.position + new Vector3(availableDirection.x, availableDirection.y);
                    float distance = (Enemy.Target.position - newPosition).sqrMagnitude;

                    if (distance < minDistance)
                    {
                        direction = availableDirection;
                        minDistance = distance;
                    }
                }

                Enemy.Movement.SetDir(direction);
            }
        }
    }
}