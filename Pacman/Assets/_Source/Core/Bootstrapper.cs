using System;
using System.Collections.Generic;
using EnemySystem;
using GameStates;
using InputSystem;
using LivesSystem;
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
        [SerializeField] private AEnemy enemy;
        [SerializeField] private PelletList pelletList;
        [SerializeField] private EnemyListener enemyListener;
        [SerializeField] private int maxPelletValue;
        [SerializeField] private int maxLives;
        [SerializeField] private List<AEnemy> enemies;
        private Lives _lives;
        private PlayerMovement _iMovable;
        private PlayerMovement _enemyMovement;
        private Score _score;
        private GameStateMachine _gameStateMachine;
        private void Awake()
        {
            _lives = new Lives(maxLives);
            
            _score = new Score(maxPelletValue);
            scoreView.Construct(_score);
            pelletList.Construct(_score);
            _iMovable = new PlayerMovement(player);
            _enemyMovement = new PlayerMovement(enemy);
            enemy.Construct(_enemyMovement);
            
            AState[] states = { new WinState(),
                new DefaultState(_score, _lives),
                new LoseState(),
                new ReloadState(player,_lives,enemies) };
            _gameStateMachine = new GameStateMachine(states);
            enemyListener.Construct(enemy, _enemyMovement);
            inputListener.Constructor(_iMovable,player);
        }
    }
}
