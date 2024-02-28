namespace Core
{
    public abstract class AState
    {
        protected IStateMachine Owner;
        
        public void AssignOwner(IStateMachine owner) => Owner = owner;
        
        public abstract void Enter();
        public abstract void Exit();
    }
}