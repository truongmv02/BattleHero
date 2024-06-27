using System;
using System.Collections;
using UnityEngine;

public interface IState
{
    void OnEnter();
    void Update();
    void FixedUpdate();
    void OnExit();
}

public abstract class BaseState : IState
{
    protected float crossFadeDuration = 0.1f;
    protected Animator animator;
    protected readonly int stateHashName;
    public BaseState(Animator animator, string stateName)
    {
        this.animator = animator;
        stateHashName = Animator.StringToHash(stateName);
    }
    public virtual void OnEnter()
    {
        animator.CrossFade(stateHashName, crossFadeDuration);
    }

    public virtual void Update()
    {
    }
    public virtual void FixedUpdate()
    {
    }
    public virtual void OnExit()
    {
    }

}
