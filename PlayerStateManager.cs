using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerStateMachine playerStateMachine = new PlayerStateMachine();

    void Start()
    {
        playerStateMachine.ChangeState(playerStateMachine.states.start, gameObject);
    }

    void Update()
    {
        playerStateMachine.Update();
    }
}
