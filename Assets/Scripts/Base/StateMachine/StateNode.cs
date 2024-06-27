
using System.Collections.Generic;

public class StateNode
{
    public IState State { get; }
    public HashSet<Transition> Transitions { get; }
    public StateNode(IState state)
    {
        this.State = state;
        Transitions = new();
    }

    public void AddTransition(IState to, ICondition condition)
    {
        Transitions.Add(new Transition(to, condition));
    }


}