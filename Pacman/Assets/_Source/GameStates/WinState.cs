using Core;
using UnityEngine;

namespace GameStates
{
    public class WinState : AState
    {
        public override void Enter()
        {
            Debug.Log("Win");
        }

        public override void Exit()
        {
            
        }

        public WinState() 
        {
            
        }
    }
}