using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateStart : PlayerState
{
    PlayerStateMachine playerStateMachine;
    GameObject gameObject;
    Transform transform;

    public void Enter(params object[] _args)
    {
        playerStateMachine = (PlayerStateMachine) _args[0];
        gameObject = (GameObject) _args[1];
        transform = gameObject.transform;

        Debug.Log("entering start state");
    }
 
    public void Execute()
    {
        Debug.Log("updating start state");
    }
 
    public void Exit()
    {
        Debug.Log("exiting test state");
    }
}