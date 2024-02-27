using Core;
using UnityEngine;

namespace GameStates
{
    public class DefaultState : AState
    {
        public override void Enter()
        {
            
            throw new System.NotImplementedException();
        }

        public override void Exit()
        {
            throw new System.NotImplementedException();
        }

        public DefaultState(IStateMachine owner) : base(owner)
        {
        }
    }
}
