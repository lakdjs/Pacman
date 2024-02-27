using Core;

namespace GameStates
{
    public class LoseState : AState
    {
        public override void Enter()
        {
            //TODO ну там отключить все!
        }

        public override void Exit()
        {
            //TODO включить
        }

        public LoseState(IStateMachine owner) : base(owner)
        {
            
        }
    }
}