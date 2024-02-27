using Core;
using UnityEngine;

namespace GameStates
{
    public class DefaultState : AState
    {
        
        public override void Enter()
        {
            
            //что то
        }

        public override void Exit()
        {
           //и здесь что то
        }

        private void Win()
        {
            
        }

        public DefaultState(IStateMachine owner) : base(owner)
        {
        }
    }
}
