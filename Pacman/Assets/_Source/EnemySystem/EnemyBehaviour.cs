using UnityEngine;

namespace EnemySystem
{
    public class EnemyBehaviour : MonoBehaviour
    {
    
        public AEnemy Enemy { get; private set; }
        [field:SerializeField] protected float duration { get; private set; }

        private void Awake()
        {
            Enemy = GetComponent<AEnemy>();
        }

        public void Enable()
        {
            Enable(duration);
        }

        public virtual void Enable(float duration)
        { 
            enabled = true;

            CancelInvoke();
            Invoke(nameof(Disable), duration);
        }

        public virtual void Disable()
        {
            enabled = false;

            CancelInvoke();
        }
    }
}
