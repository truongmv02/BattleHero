using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : EntityController
{
    [field: SerializeField] public InputReader Input { protected set; get; }
    public PlayerAnimationEvent AnimEventHandler { protected set; get; }
    public PlayerActionStateMachine actionStateMachine { protected set; get; }
    public bool CanAttack { set; get; } = true;
    protected override void Awake()
    {
        base.Awake();
        AnimEventHandler = GetComponentInChildren<PlayerAnimationEvent>();
        StateMachine = new PlayerStateMachine(this);
        actionStateMachine = new PlayerActionStateMachine(this);
    }

    protected override void Update()
    {
        base.Update();
        actionStateMachine.Update();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        actionStateMachine.FixedUpdate();
    }
}
