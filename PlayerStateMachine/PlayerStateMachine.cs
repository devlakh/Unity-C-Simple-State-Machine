using UnityEngine;

public interface PlayerState
{
    void Enter(params object[] _args);
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

    public void ChangeState(PlayerState _newState, params object[] _args)
    {
        if (currentState != null)
            currentState.Exit();
 
        currentState = _newState;
        currentState.Enter(_args);
    }
 
    public void Update()
    {
        if (currentState != null) currentState.Execute();
    }
}
