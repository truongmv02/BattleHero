using System;

public interface ICondition
{
    bool IsSuitable { get; }
    Action OnSuitable { set; }
    void ResetCondition();
}

public abstract class Condition : ICondition
{
    protected bool isSuitable;
    protected Action onSuitable;
    public virtual bool IsSuitable => isSuitable;
    public Action OnSuitable { set => onSuitable = value; }

    public virtual void ResetCondition()
    {
        isSuitable = false;
    }
}


public class FuncCondition : Condition
{
    readonly Func<bool> func;

    public FuncCondition(Func<bool> func) => this.func = func;

    public override bool IsSuitable => func.Invoke();
}