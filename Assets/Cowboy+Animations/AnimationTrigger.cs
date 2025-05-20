using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationTrigger : MonoBehaviour
{
    public Animator characterAnimator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            characterAnimator.Play("IdleToWalk");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            characterAnimator.Play("WalkToRun");
        }
    }
}
