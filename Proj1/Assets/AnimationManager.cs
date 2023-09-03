using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator _Animator;

    private void Start()
    {
        _Animator = GetComponent<Animator>();
    }

    public void SetAnimationIdle() => _Animator.SetInteger("Animation", 0);
    
    public void SetAnimationRun() => _Animator.SetInteger("Animation", 1);

    public void SetAnimationJump() => _Animator.SetInteger("Animation", 2);

    public void SetAnimationAttack() => _Animator.SetInteger("Animation", 3);
}
