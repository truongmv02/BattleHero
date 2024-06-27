using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    protected Dictionary<Type, StateNode> StateNodes = new();
    HashSet<ITransition> anyTransitions = new();
    public StateNode CurrentState { protected set; get; }

    public void Update()
    {
        var transition = GetTransition();
        if (transition != null)
        {
            ChangeState(transition.To);
        }

        CurrentState.State?.Update();
    }


    public void FixedUpdate()
    {
        CurrentState.State?.FixedUpdate();
    }

    public void SetState(IState state)
    {
        CurrentState = StateNodes[state.GetType()];
        CurrentState.State?.OnEnter();
    }

    public void ChangeState(IState state)
    {
        if (state == CurrentState.State) return;
        CurrentState.State?.OnExit();
        CurrentState = StateNodes[state.GetType()];
        CurrentState.State?.OnEnter();
    }

    ITransition GetTransition()
    {
        foreach (var transition in anyTransitions)
        {
            if (transition.Condition.IsSuitable)
                return transition;
        }

        foreach (var transition in CurrentState.Transitions)
        {
            if (transition.Condition.IsSuitable)
                return transition;
        }

        return null;
    }

    public void AddTransition(IState from, IState to, ICondition condition)
    {
        GetOrAddNode(from).AddTransition(GetOrAddNode(to).State, condition);
    }

    public void AddAnyTransition(IState to, ICondition condition)
    {
        anyTransitions.Add(new Transition(to, condition));
    }

    StateNode GetOrAddNode(IState state)
    {
        var node = StateNodes.GetValueOrDefault(state.GetType());
        if (node == null)
        {
            node = new StateNode(state);
            StateNodes.Add(state.GetType(), node);
        }

        return node;

    }

}
