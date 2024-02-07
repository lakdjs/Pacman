using System;
using InputSystem;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Player player;
        private IMovable _iMovable;
        private void Awake()
        {
            _iMovable = new PlayerMovement(player.PlayerSpeed,player.PlayerRb, player.transform);
            inputListener.Constructor(_iMovable,player);
        }
    }
}
