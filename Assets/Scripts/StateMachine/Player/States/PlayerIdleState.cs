

using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public PlayerIdleState(Animator animator, string stateName, PlayerController player) : base(animator, stateName, player)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();

    }
}