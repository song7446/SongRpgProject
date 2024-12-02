using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charater
{
    public InputControl InputControl = null;
    public Animator Animator = null;

    public override void Init()
    {
        Charater_Type = ECHARATER_TYPE.PLAYER;
        State = ECHARATER_STATE.IDLE;
    }

    private void FixedUpdate()
    {
        Vector3 moveVec = Vector3.zero;
        moveVec.x = InputControl.MoveInput.x;
        moveVec.z = InputControl.MoveInput.y;

        transform.position += moveVec;
    }

    private void OnAnimatorMove()
    {
        transform.position += Animator.deltaPosition;
    }
}
