using UnityEngine;

public class PlayerStateStart : PlayerState
{
    GameObject gameObject;
    Transform transform;

    public void Enter(GameObject _gameObject)
    {
        gameObject = _gameObject;
        transform = _gameObject.transform;
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