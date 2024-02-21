using System;
using InputSystem;
using PelletSystem;
using PlayerSystem.Data;
using PlayerSystem.Movement;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private ScoreView scoreView;
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Player player;
        [SerializeField] private PelletList pelletList;
        private PlayerMovement _iMovable;
        private Score _score;
        private void Awake()
        {
            _score = new Score();
            scoreView.Construct(_score);
            pelletList.Construct(_score);
            _iMovable = new PlayerMovement(player);
            inputListener.Constructor(_iMovable,player);
        }
    }
}
