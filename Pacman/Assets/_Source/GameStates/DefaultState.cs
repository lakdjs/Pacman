using Core;
using LivesSystem;
using PelletSystem;
using Unity.VisualScripting;
using UnityEngine;

namespace GameStates
{
    public class DefaultState : AState
    {
        private Score _score;
        private Lives _lives;
        public override void Enter()
        {
            _score.OnMaxPellet += Win;
            _lives.OnLifeDeleted += Reload;
            _lives.OnPacManDied += Loose;
            //что то
        }

        public override void Exit()
        {
            _score.OnMaxPellet -= Win;
            _lives.OnLifeDeleted -= Reload;
            _lives.OnPacManDied -= Loose;
            //и здесь что то
        }

        private void Win()
        {
            Owner.ChangeStateByType<WinState>();
        }

        private void Reload()
        {
            Owner.ChangeStateByType<ReloadState>();
        }

        private void Loose()
        {
            Owner.ChangeStateByType<LoseState>();
        }
        public DefaultState( Score score, Lives lives) 
        {
            _score = score;
            _lives = lives;
        }
    }
}
