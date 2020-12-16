using UnityEngine;

public class PlayerStateGround : PlayerState
{
    public void Enter()
    {
        Debug.Log("entering test state");
    }
 
    public void Execute()
    {
        Debug.Log("updating test state");
    }
 
    public void Exit()
    {
        Debug.Log("exiting test state");
    }
}
