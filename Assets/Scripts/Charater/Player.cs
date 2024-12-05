using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Player : Charater
{
    public InputControl InputControl = null;
    public Animator Animator = null;
    public float MoveSpeed = 0.3f;

    Vector3 moveVec = Vector3.zero;

    private readonly int Velocity_Hash = Animator.StringToHash("Velocity");
    private readonly int Input_Hash = Animator.StringToHash("Input");

    private float Velocity = 0f;

    public override void Init()
    {
        Charater_Type = ECHARATER_TYPE.PLAYER;
        State = ECHARATER_STATE.IDLE;
    }

    private void FixedUpdate()
    {
        moveVec.x = InputControl.MoveInput.x;
        moveVec.z = InputControl.MoveInput.y;
        if (moveVec.magnitude < 0.1f)
        {
            Velocity = Mathf.Clamp01(Velocity - 0.1f);
        }
        else
        {
            Velocity = Mathf.Clamp01(Velocity + (moveVec.magnitude * Time.deltaTime));
        }

        Animator.SetBool(Input_Hash, Velocity>0.2f);

        if (Velocity < 0.1f)
        {
            Idle();
        }
        else
        {
            // ÀÌµ¿
            Move();
            transform.position += moveVec * MoveSpeed;           
        }
    }

    public override void Idle()
    {
        Animator.SetFloat(Velocity_Hash, 0f);
    }

    public override void Move()
    {
        Animator.SetFloat(Velocity_Hash, 1f);
        MoveSpeed = 0.3f;
    }
}
