using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : EntityController
{
    [field: SerializeField] public InputReader Input { protected set; get; }

    public bool CanAttack { set; get; } = true;
    protected override void Awake()
    {
        base.Awake();
        StateMachine = new PlayerStateMachine(this);
    }
}
