using System;
using System.Collections;
using UnityEngine;

public class PlayerAnimationEvent : MonoBehaviour
{
    public event Action OnFinish;
    private void AnimationFinishTrigger() => OnFinish?.Invoke();
}
