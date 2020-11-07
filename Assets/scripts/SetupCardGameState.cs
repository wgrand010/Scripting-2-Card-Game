using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupCardGameState : CardGameState
{
    [SerializeField] int _startingCardNumber = 5;
    [SerializeField] int _numberOfPlayers = 2;

    public CardGameUIController UIcontroller;
    bool _activated = false;

    public override void Enter ()
    {
        Debug.Log("Setup: ...Entering");
        Debug.Log("Creating " + _numberOfPlayers + " players.");
        Debug.Log("Creating deck with " + _startingCardNumber + " cards.");

        //Cant change state while still in enter()/Exit() transition!
        //Dont put changestate<> here.
        _activated = false;
    }

    public override void Tick()
    {
        //usually have delay or Input
        if (_activated == false)
        {
            UIcontroller.DrawFirstCards();
            _activated = true;
            StateMachine.ChangeState<PlayerTurnCardGameState>();
        }
    }

    public override void Exit()
    {
        _activated = false;
        Debug.Log("Setup: Exiting...");
    }
}
