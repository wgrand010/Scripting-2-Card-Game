using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameSM : StateMachine
{
    [SerializeField] InputController _input;
    public InputController Input => _input;
    void Start()
    {
        //Ende up putting menu as scene , first state can be left as setup
        ChangeState<SetupCardGameState>();
    }
}
