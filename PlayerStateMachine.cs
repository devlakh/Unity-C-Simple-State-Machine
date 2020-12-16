public interface PlayerState
{
    void Enter();
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

    public void ChangeState(PlayerState newState)
    {
        if (currentState != null)
            currentState.Exit();
 
        currentState = newState;
        currentState.Enter();
    }
 
    public void Update()
    {
        if (currentState != null) currentState.Execute();
    }
}
