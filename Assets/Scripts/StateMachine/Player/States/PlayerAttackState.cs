

using System.Linq;
using UnityEngine;

public class PlayerAttackState : PlayerState
{
    public PlayerAttackState(Animator animator, string stateName, PlayerController player) : base(animator, stateName, player)
    {
        player.AnimEventHandler.OnFinish += AnimationFinish;
    }

    public override void OnEnter()
    {
        base.OnEnter();
        player.CanAttack = false;
    }

    public override void OnExit()
    {
        base.OnExit();
    }

    void AnimationFinish()
    {
        player.CanAttack = true;
    }
}