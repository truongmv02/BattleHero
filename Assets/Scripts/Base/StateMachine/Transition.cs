public interface ITransition
{
    IState To { get; }
    ICondition Condition { get; }
}

public class Transition : ITransition
{
    public IState To { get; }

    public ICondition Condition { get; }

    public Transition(IState to, ICondition condition)
    {
        To = to;
        Condition = condition;
    }
}