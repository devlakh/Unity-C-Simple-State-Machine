using UnityEngine;

public class PlayerStateStart : PlayerState
{
    PlayerStateMachine playerStateMachine;
    PlayerAttributes playerAttributes;
    PlayerObjects playerObjects;
    GameObject gameObject;
    Transform transform;

    public void Enter(params object[] _args)
    {
        playerStateMachine = (PlayerStateMachine) _args[0];
        playerAttributes = (PlayerAttributes) _args[1];
        playerObjects = (PlayerObjects) _args[2];
        gameObject = (GameObject) _args[3];
        
        transform = gameObject.transform;

        Debug.Log("entering start state");
    }
 
    public void Execute()
    {
        if(Input.GetKeyDown("enter") || Input.GetKeyDown("return"))
        {
            playerStateMachine.ChangeState(
                playerStateMachine.states.ground,
                playerStateMachine,
                playerAttributes,
                playerObjects,
                gameObject
            );
        }
        Debug.Log("updating start state");
    }
 
    public void Exit()
    {
        Debug.Log("exiting start state");
    }
}