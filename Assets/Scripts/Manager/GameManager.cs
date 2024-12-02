using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public Charater Player = null;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        Player.Init();
    }

    public Charater GetPlayer()
    {
        return Player;
    }
}
