using UnityEngine;

namespace PlayerSystem.Data
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public int PlayerLives { get; private set; }
        [field: SerializeField] public float PlayerSpeed { get; private set; }
        [field: SerializeField] public Rigidbody2D PlayerRb { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeLeft { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeRight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeStraight { get; private set; }
        [field: SerializeField] public KeyCode KeyCodeBack { get; private set; }

        public void ChangeDir(Vector3 dir)
        {
           transform.rotation = Quaternion.Euler(dir);
        }
    }
}
