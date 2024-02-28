using System.Collections;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyHome : EnemyBehaviour
    {
        public Transform inside;
        public Transform outside;

        private void OnEnable()
        {
            StopAllCoroutines();
        }

        private void OnDisable()
        {
            // Check for active self to prevent error when object is destroyed
            if (gameObject.activeInHierarchy) {
                StartCoroutine(ExitTransition());
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // Reverse direction everytime the ghost hits a wall to create the
            // effect of the ghost bouncing around the home
            if (enabled && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle")) {
                Enemy.Movement.SetDir(-Enemy.CurrDir);
            }
        }

        private IEnumerator ExitTransition()
        {
            // Turn off movement while we manually animate the position
            Enemy.Movement.SetDir(Vector2.up, true);
            Enemy.Rb.isKinematic = true;
            Enemy.EnemyListener.enabled = false;

            Vector3 position = transform.position;

            float duration = 0.5f;
            float elapsed = 0f;

            // Animate to the starting point
            while (elapsed < duration)
            {
                Enemy.SetPosition(Vector3.Lerp(position, inside.position, elapsed / duration));
                elapsed += Time.deltaTime;
                yield return null;
            }

            elapsed = 0f;

            // Animate exiting the ghost home
            while (elapsed < duration)
            {
                Enemy.SetPosition(Vector3.Lerp(inside.position, outside.position, elapsed / duration));
                elapsed += Time.deltaTime;
                yield return null;
            }

            // Pick a random direction left or right and re-enable movement
            Enemy.Movement.SetDir(new Vector2(Random.value < 0.5f ? -1f : 1f, 0f), true);
            Enemy.Rb.isKinematic = false;
            Enemy.EnemyListener.enabled = true;
        }
    }
}