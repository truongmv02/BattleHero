using System.Collections;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public PlayerStateMachine() { }
    public PlayerStateMachine(PlayerController player)
    {
        Init(player);
    }
    public void Init(PlayerController player)
    {
        PlayerIdleState idleState = new PlayerIdleState(player.Animator, "IdleBattle", player);
        PlayerRunState runState = new PlayerRunState(player.Animator, "Run", player);

        AddTransition(idleState, runState, new FuncCondition(() =>
        {
            return !player.Input.Direction.Equals(Vector2.zero);
        }));

        AddTransition(runState, idleState, new FuncCondition(() =>
        {
            return player.Input.Direction.Equals(Vector2.zero);
        }));

        SetState(idleState);
    }
}
