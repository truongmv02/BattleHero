using System.Collections;
using UnityEngine;

[System.Serializable]
public class MoveInfo
{
    public float speed;
}

[DisallowMultipleComponent]
public class MoveController : MonoBehaviour
{
    protected Rigidbody _rigidbody;
    public bool CanMove { get; set; }

    public float Speed { get; set; }

    public int FacingDirection { get; private set; }

    public Vector3 CurrentVelocity => _rigidbody.velocity;


    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public virtual void Move(Vector3 direction)
    {
        Move(Speed, direction);
    }
    public virtual void Move(float speed, Vector3 direction)
    {
        direction = direction.normalized;
        SetFinalVelocity(direction * speed);
    }

    public virtual void Stop()
    {
        SetFinalVelocity(Vector3.zero);
    }

    protected virtual void SetFinalVelocity(Vector3 velocity)
    {
        if (!CanMove) return;
        _rigidbody.velocity = velocity;
    }

    private void OnEnable()
    {
        CanMove = true;
        FacingDirection = 1;
    }
}
