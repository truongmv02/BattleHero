using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : BaseState
{
    protected PlayerController player;
    public PlayerState(Animator animator, string stateName, PlayerController player) : base(animator, stateName)
    {
        this.player = player;
    }
}
