

using UnityEngine;

public class PlayerAttackState : PlayerState
{
    public PlayerAttackState(Animator animator, string stateName, PlayerController player) : base(animator, stateName, player)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        player.CanAttack = false;
    }

    public override void OnExit()
    {
        base.OnExit();
        player.CanAttack = true;
    }

}