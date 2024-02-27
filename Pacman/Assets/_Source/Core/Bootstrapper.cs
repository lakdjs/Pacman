using System;
using System.Collections.Generic;
using EnemySystem;
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
        [SerializeField] private AEnemy enemies;
        [SerializeField] private PelletList pelletList;
        [SerializeField] private EnemyListener enemyListener;
        private PlayerMovement _iMovable;
        private PlayerMovement _enemyMovement;
        private Score _score;
        private void Awake()
        {
            
            _score = new Score();
            scoreView.Construct(_score);
            pelletList.Construct(_score);
            _iMovable = new PlayerMovement(player);
            _enemyMovement = new PlayerMovement(enemies);
            enemies.Construct(_enemyMovement);
            
            enemyListener.Construct(enemies, _enemyMovement);
            inputListener.Constructor(_iMovable,player);
        }
    }
}
