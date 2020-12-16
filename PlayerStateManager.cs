using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    public PlayerStateMachine playerStateMachine = new PlayerStateMachine();

    void Start()
    {
        playerStateMachine.ChangeState(playerStateMachine.states.start, playerStateMachine, gameObject);
    }

    void Update()
    {
        playerStateMachine.Update();
    }
}
