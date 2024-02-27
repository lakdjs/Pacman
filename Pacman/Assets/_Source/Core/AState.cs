namespace Core
{
    public abstract class AState
    {
        protected IStateMachine Owner;

        protected AState(IStateMachine owner)
        {
            Owner = owner;
        }
        public void AssignOwner(IStateMachine owner) => Owner = owner;
        
        public abstract void Enter();
        public abstract void Exit();
    }
}