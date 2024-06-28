using System.Collections;
using UnityEngine;

public class PlayerActionStateMachine : StateMachine
{
    public PlayerActionStateMachine() { }
    public PlayerActionStateMachine(PlayerController player)
    {
        Init(player);
    }
    public void Init(PlayerController player)
    {
        PlayerState emptyState = new PlayerIdleState(player.Animator, "Empty", player);
        PlayerAttackState attackState = new PlayerAttackState(player.Animator, "Attack", player);

        AddTransition(emptyState, attackState, new FuncCondition(() =>
        {
            return player.Input.Fire && player.CanAttack;
        }));
        AddTransition(attackState, emptyState, new FuncCondition(() =>
        {
            return !player.Input.Fire && player.CanAttack;
        }));


        SetState(emptyState);
    }
}
