using System.Collections.Generic;
using System.Net.NetworkInformation;
using Core;
using EnemySystem;
using LivesSystem;
using PlayerSystem.Data;

namespace GameStates
{
    public class ReloadState : AState
    {
        private Player _player;
        private Lives _lives;
        private List<AEnemy> _enemies;
        public override void Enter()
        {
            _player.ResetState();
            foreach (AEnemy enemy in _enemies)
            {
                enemy.ResetState();
            }
            _lives.SetLives();
            Owner.ChangeStateByType<DefaultState>();
        }

        public override void Exit()
        {
            //что то 
        }

        public ReloadState( Player player, Lives lives, List<AEnemy> enemies) 
        {
            _player = player;
            _lives = lives;
            _enemies = enemies;
        }
    }
}