using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ECHARATER_TYPE
{
    NONE,
    PLAYER,
    ENEMY,
}

public enum ECHARATER_STATE
{
    NONE,
    IDLE,
    SEARCH,
    MOVE,
    ATTACK,
    DEAD
}

public class Charater : MonoBehaviour
{
    public ECHARATER_TYPE Charater_Type = ECHARATER_TYPE.NONE;
    public ECHARATER_STATE State = ECHARATER_STATE.NONE;

    public virtual void Init()
    {

    }

    public virtual void Idle()
    {

    }

    public virtual void Move()
    {

    }

    public virtual void Dash()
    {

    }
}
