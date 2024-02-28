using System.Collections.Generic;
using Core;
using EnemySystem;
using LivesSystem;
using PlayerSystem.Data;

namespace GameStates
{
    public class LoseState : AState
    {
        private Player _player;
        private List<AEnemy> _enemies;
        private Lives _lives;
        public override void Enter()
        {
            
            //TODO ну там отключить все!
        }

        public override void Exit()
        {
            //TODO включить
        }

        public LoseState() 
        {
            
        }

        private void Reload()
        {
            Owner.ChangeStateByType<ReloadState>();
        }
    }
}