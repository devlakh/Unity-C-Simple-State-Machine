using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerStateMachine playerStateMachine;
    PlayerAttributes playerAttributes;
    PlayerObjects playerObjects;

    void Start()
    {
        playerStateMachine = new PlayerStateMachine();
        playerAttributes = gameObject.GetComponent<PlayerAttributes>();
        playerObjects = gameObject.GetComponent<PlayerObjects>();
        
        playerStateMachine.ChangeState(
            playerStateMachine.states.start,
            playerStateMachine,
            playerAttributes,
            playerObjects,
            gameObject
        );
    }

    void Update()
    {
        playerStateMachine.Update();
    }
}
