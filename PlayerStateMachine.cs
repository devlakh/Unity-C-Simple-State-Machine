using UnityEngine;

public interface PlayerState
{
    void Enter(GameObject _gameObject);
    void Execute();
    void Exit();
}

public class States
{
    public PlayerState start = new PlayerStateStart();
    public PlayerState ground = new PlayerStateGround();
}

public class PlayerStateMachine
{
    public States states = new States();
    PlayerState currentState;

    public void ChangeState(PlayerState _newState, GameObject _gameObject)
    {
        if (currentState != null)
            currentState.Exit();
 
        currentState = _newState;
        currentState.Enter(_gameObject);
    }
 
    public void Update()
    {
        if (currentState != null) currentState.Execute();
    }
}
