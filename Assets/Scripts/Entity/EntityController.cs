using System.Collections;
using UnityEngine;

public abstract class EntityController : MonoBehaviour
{
    public Rigidbody Rigidbody { protected set; get; }
    public MoveController Movement { protected set; get; }
    public EntityModel EntityModel { protected set; get; }
    public StateMachine StateMachine { protected set; get; }
    public Animator Animator { protected set; get; }

    protected virtual void Awake()
    {
        Movement = GetComponent<MoveController>();
        Rigidbody = GetComponent<Rigidbody>();
        EntityModel = GetComponentInChildren<EntityModel>();
        Animator = GetComponentInChildren<Animator>();
    }

    protected virtual void Start() { }
    protected virtual void Update()
    {
        StateMachine?.Update();
    }
    protected virtual void FixedUpdate()
    {
        StateMachine?.FixedUpdate();
    }
    protected virtual void OnEnable() { }
    protected virtual void OnDisable() { }
    protected virtual void OnDestroy() { }
}
