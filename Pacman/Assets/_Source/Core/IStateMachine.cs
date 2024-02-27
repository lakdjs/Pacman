namespace Core
{
    public interface IStateMachine
    {
        bool ChangeStateByType<T>();
    }
}
