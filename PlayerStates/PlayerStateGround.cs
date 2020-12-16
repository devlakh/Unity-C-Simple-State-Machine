using UnityEngine;

public class PlayerStateGround : PlayerState
{
    GameObject gameObject;
    Transform transform;

    public void Enter(GameObject _gameObject)
    {
        gameObject = _gameObject;
        transform = _gameObject.transform;
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
