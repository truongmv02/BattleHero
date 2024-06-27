

using UnityEngine;

public class PlayerRunState : PlayerState
{
    public PlayerRunState(Animator animator, string stateName, PlayerController player) : base(animator, stateName, player)
    {

    }

    public override void Update()
    {
        base.Update();
        Vector3 inputDirection = player.Input.Direction;
        Vector3 moveDirection = new Vector3(inputDirection.x, 0f, inputDirection.y);
        player.Movement.Move(3, moveDirection);
    }

    public override void OnExit()
    {
        base.OnExit();
        player.Movement.Stop();
    }

}