using UnityEngine;

namespace EnemySystem
{
    public class EnemyScatter : EnemyBehaviour
    {
        private void OnDisable()
        {
            Enemy.Chase.Enable();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Node node = other.GetComponent<Node>();
            if (node != null && enabled /*&& !Enemy.Frightened.enabled*/)
            {
                int index = Random.Range(0, node.AvailableDirections.Count);
                foreach (Vector2 dir in node.AvailableDirections)
                {
                    Debug.Log(dir);
                }
                if (node.AvailableDirections.Count > 1 && node.AvailableDirections[index] == -Enemy.CurrDir)
                {
                    index++;
                    
                    if (index >= node.AvailableDirections.Count) {
                        index = 0;
                    }
                }
                Debug.Log("E");
                Enemy.Movement.SetDir(node.AvailableDirections[index], true);
            }
        }
    }
}